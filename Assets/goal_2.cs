using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal_2 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ball>())
        {
            GameManager.Instance.player_2_goals += 1;
            Debug.Log("Score for player blue");
            GameManager.Instance.Reset();
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Goal_and_Restart()
    {
        yield return new WaitForSeconds(2f);
    }
}