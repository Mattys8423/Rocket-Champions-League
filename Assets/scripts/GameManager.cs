using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool DontDestroy;
    [SerializeField] private ball ball;
    [SerializeField] private move move1;
    [SerializeField] private move move2;
    [SerializeField] private Timer Timer;
    private Reprendre Reprendre;
    public int player_1_goals;
    public int player_2_goals;

    public static float temps_pause;
    public static int goal_player_1;
    public static int goal_player_2;

    private static GameManager instance = null;

    private void Start()
    {
        DontDestroy = false;

        if (DontDestroy)
        {
            DontDestroyOnLoad(this.gameObject);
        }

        if (Reprendre.Repris == true)
        {
            player_1_goals = goal_player_1;
            player_2_goals = goal_player_2;
            Timer.temps = temps_pause;
            DontDestroy = false;
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DontDestroy = true;
            SceneManager.LoadScene(5);
            temps_pause = Timer.temps;
            goal_player_1 = player_1_goals;
            goal_player_2 = player_2_goals;
        }
    }

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

        // Initialisation du Game Manager...
    }

    public void Reset()
    {
        ball.Respawn_ball();
        move1.Respawn_player();
        move2.Respawn_player();
    }   

    public void Restart()
    {
        player_1_goals = 0;
        player_2_goals = 0;
    }

}
