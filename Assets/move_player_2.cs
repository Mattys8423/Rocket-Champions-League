using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_player_2: MonoBehaviour
{
    [SerializeField] private int movementSpeed;
    [SerializeField] private int minmovementSpeed;
    [SerializeField] private int maxmovementSpeed;
    [SerializeField] private float angular_speed;
    [SerializeField] private int Jetpack_Force;
    [SerializeField] private int min_Jetpack_Force;
    [SerializeField] private int max_Jetpack_Force;
    [SerializeField] private GameObject Player_2_Start;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("HorizontalPlayer2");
        float vert = Input.GetAxis("VerticalPlayer2");
        Mathf.Clamp(movementSpeed, minmovementSpeed, maxmovementSpeed);

        transform.Rotate(transform.up, angular_speed * hor);

        //Camera.FieldOfView = Mathf.Lerp(60, 75, Rigidbody)
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Keypad8))
            if (Input.GetKey(KeyCode.KeypadEnter))
                GetComponent<Rigidbody>().AddForce(transform.forward * movementSpeed * 2);
            else
                GetComponent<Rigidbody>().AddForce(transform.forward * movementSpeed);
        if (Input.GetKey(KeyCode.Keypad5))
            GetComponent<Rigidbody>().AddForce(transform.forward * -movementSpeed);
        if (Input.GetKey(KeyCode.RightShift))
            GetComponent<Rigidbody>().AddForce(transform.up * Jetpack_Force);
        if (Input.GetKey(KeyCode.UpArrow))
            GetComponent<Rigidbody>().AddForce(-transform.up * Jetpack_Force);
    }

    public void Respawn_player_1()
    {
        transform.position = Player_2_Start.transform.position;
        transform.rotation = Player_2_Start.transform.rotation;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}