using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{

    [SerializeField] public int goal_number;
    [SerializeField] public GameObject particule;
    [SerializeField] private GameObject ball;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ball>())
        {
            if (goal_number == 1)
            {
                GameManager.Instance.player_1_goals += 1;
                ball.SetActive(false);
            }
            if (goal_number == 2)
            {
                GameManager.Instance.player_2_goals += 1;
                ball.SetActive(false);
            }

            particule.SetActive(true);
            StartCoroutine(Goal_and_Restart());

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        particule.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Goal_and_Restart()
    {
        yield return new WaitForSeconds(2f);
        particule.SetActive(false);
        ball.SetActive(true);
        GameManager.Instance.Reset();
    }
}