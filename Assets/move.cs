using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] private int movementSpeed;
    [SerializeField] private int minmovementSpeed;
    [SerializeField] private int maxmovementSpeed;
    [SerializeField] private float angular_speed;
    [SerializeField] private int Jetpack_Force;
    [SerializeField] private int min_Jetpack_Force;
    [SerializeField] private int max_Jetpack_Force;
    [SerializeField] private bool use_Jetpack;
    [SerializeField] private int fuel;
    [SerializeField] private GameObject Player_1_Start;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("HorizontalPlayer1");
        float vert = Input.GetAxis("VerticalPlayer1");
        Mathf.Clamp(movementSpeed, minmovementSpeed, maxmovementSpeed);

        transform.Rotate(transform.up, angular_speed * hor);

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            if (Input.GetKey(KeyCode.LeftShift))
                GetComponent<Rigidbody>().AddForce(transform.forward * movementSpeed * 2);
            else
                GetComponent<Rigidbody>().AddForce(transform.forward * movementSpeed);
        if (Input.GetKey(KeyCode.S))
            GetComponent<Rigidbody>().AddForce(transform.forward * -movementSpeed);
        if(Input.GetKey(KeyCode.Space))
            GetComponent<Rigidbody>().AddForce(transform.up * Jetpack_Force);
        if (Input.GetKey(KeyCode.LeftControl))
            GetComponent<Rigidbody>().AddForce(-transform.up * Jetpack_Force);
    }

    public void Respawn_player_1()
    {
        transform.position = Player_1_Start.transform.position;
        transform.rotation = Player_1_Start.transform.rotation;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}