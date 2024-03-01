using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ball ball;
    [SerializeField] private move move;
    [SerializeField] private move_player_2 move_player_2;
    public int player_1_goals;
    public int player_2_goals;

    private static GameManager instance = null;
    public static GameManager Instance => instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);

        // Initialisation du Game Manager...
    }

    public void Reset()
    {
        ball.Respawn_ball();
        move.Respawn_player_1();
        move_player_2.Respawn_player_1();
    }

}
