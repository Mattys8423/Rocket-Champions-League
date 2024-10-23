using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private GameObject arrowobject;
    [SerializeField] private ball ball;
    [SerializeField] private float angle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        arrowobject.transform.rotation = Quaternion.LookRotation(ball.transform.position - transform.position) * Quaternion.Euler(angle, 0, 0);
    }
}
