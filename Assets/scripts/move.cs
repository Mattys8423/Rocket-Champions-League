using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    [SerializeField] private int movementSpeed;
    [SerializeField] private int minmovementSpeed;
    [SerializeField] private int maxmovementSpeed;
    [SerializeField] private float angular_speed;

    [SerializeField] private int Jetpack_Force;
    [SerializeField] private int min_Jetpack_Force;
    [SerializeField] private int max_Jetpack_Force;

    [SerializeField] private int force;

    [SerializeField] private GameObject Player_Start;
    [SerializeField] private slider slider;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private ball ball;

    [SerializeField] public int player;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Cursor.visible = false;
        Respawn_player();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("HorizontalPlayer1");
        float hor2 = Input.GetAxis("HorizontalPlayer2");
        movementSpeed = Mathf.Clamp(movementSpeed, minmovementSpeed, maxmovementSpeed);

        if (player == 1)
        {
            transform.Rotate(transform.up, angular_speed * hor);
        }

        if (player == 2)
        {
            transform.Rotate(transform.up, angular_speed * hor2);
        }

    }

    void FixedUpdate()
    {
        if (player == 1)
        {
            if (Input.GetKey(KeyCode.W))
                if (Input.GetKey(KeyCode.LeftShift) || slider.fuel < 2)
                    rb.AddForce(transform.forward * movementSpeed * 2);
                else
                    rb.AddForce(transform.forward * movementSpeed);
            if (Input.GetKey(KeyCode.S))
                rb.AddForce(transform.forward * -movementSpeed);
            if (Input.GetKey(KeyCode.Space) || slider.fuel < 2)
                rb.AddForce(transform.up * Jetpack_Force);
            if (Input.GetKey(KeyCode.LeftControl) || slider.fuel < 2)
                rb.AddForce(-transform.up * Jetpack_Force);
            if (Input.GetKeyDown(KeyCode.Q) || Vector3.Distance(ball.transform.position, transform.position) == 0.3)
                ball.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * force);
        }
        else if (player == 2)
        {
            if (Input.GetKey(KeyCode.Keypad8))
                if (Input.GetKey(KeyCode.KeypadEnter) || slider.fuel < 2)
                    rb.AddForce(transform.forward * movementSpeed * 2);
                else
                    rb.AddForce(transform.forward * movementSpeed);
            if (Input.GetKey(KeyCode.Keypad5))
                rb.AddForce(transform.forward * -movementSpeed);
            if (Input.GetKey(KeyCode.RightShift) || slider.fuel < 2)
                rb.AddForce(transform.up * Jetpack_Force);
            if (Input.GetKey(KeyCode.UpArrow) || slider.fuel < 2)
                rb.AddForce(-transform.up * Jetpack_Force);
            if (Input.GetKeyDown(KeyCode.Keypad7) || Vector3.Distance(ball.transform.position, transform.position) == 0.3)
                ball.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * force);
        }


    }

    public void Respawn_player()
    {

        transform.position = Player_Start.transform.position;
        transform.rotation = Player_Start.transform.rotation;
        rb.velocity = Vector3.zero;
    }


}