using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    [SerializeField] public Camera player_camera;
    [SerializeField] private ball ball;
    [SerializeField] private move move;
    [SerializeField] private bool Ball_Cam_Active;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move.player == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Ball_Cam_Active =! Ball_Cam_Active;
            }

            if (Ball_Cam_Active == true)
            {
                player_camera.transform.rotation = Quaternion.LookRotation(ball.transform.position - transform.position);
            }
            else if (Ball_Cam_Active == false)
            {
                player_camera.transform.rotation = Quaternion.LookRotation(move.transform.position - transform.position) * Quaternion.Euler(-20, 0, 0);
            }
        }

        if (move.player == 2)
        {
            if (Input.GetKeyDown(KeyCode.Keypad9))
            {
                Ball_Cam_Active = !Ball_Cam_Active;
            }

            if (Ball_Cam_Active == true)
            {
                player_camera.transform.rotation = Quaternion.LookRotation(ball.transform.position - transform.position);
            }
            else if (Ball_Cam_Active == false)
            {
                player_camera.transform.rotation = Quaternion.LookRotation(move.transform.position - transform.position) * Quaternion.Euler(-20, 0, 0);
            }
        }

    }
}
