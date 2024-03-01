using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] private GameObject Ball_Start;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.grey;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn_ball()
    {
        transform.position = Ball_Start.transform.position;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
