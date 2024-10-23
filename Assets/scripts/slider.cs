using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class slider : MonoBehaviour {


	[SerializeField] public float fuel;
    [SerializeField] public float maxfuel;
    [SerializeField] public float minfuel;
    [SerializeField] private float fuelSpeed;   
	[SerializeField] public Slider mySlider;
    [SerializeField] private move move;

    private void Start()
    {
        SetFuel();
    }

	void Update()
	{
        fuel = Mathf.Clamp(fuel, minfuel, maxfuel);

        if (move.player == 1)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.LeftShift))
                fuel -= fuelSpeed * Time.deltaTime;
            else
                fuel += fuelSpeed * Time.deltaTime;
        }
        else if (move.player == 2)
        {
            if (Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.KeypadEnter))
                fuel -= fuelSpeed * Time.deltaTime;
            else
                fuel += fuelSpeed * Time.deltaTime;
        }

        SetFuel();

    }

    public void SetFuel()
	{
		mySlider.value = fuel;
		Debug.Log("fuel = " + fuel);
	}
}