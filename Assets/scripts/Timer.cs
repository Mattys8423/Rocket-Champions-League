using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField] public float temps;
    [SerializeField] public int temps_int;
    [SerializeField] private TMPro.TMP_Text Timer_text;
    [SerializeField] private TMPro.TMP_Text blue_score;
    [SerializeField] private TMPro.TMP_Text red_score;

    private main_menu main_menu;

    // Start is called before the first frame update
    void Start()
    {
        if (main_menu.is_time == true)
        {
            temps = main_menu.choose_time;
        }
        else
        {
            temps = 500f;
        }
        GameManager.Instance.Restart();
    }

    // Update is called once per frame
    void Update()
    {
        temps_int = Mathf.RoundToInt(temps);
        Timer_text.text = temps_int + "";
        blue_score.text = GameManager.Instance.player_2_goals + "";
        red_score.text = GameManager.Instance.player_1_goals + "";
        if (temps >= 0)
        {
            temps -= Time.deltaTime;

        }

        if (temps < 0)
        {
            if (GameManager.Instance.player_1_goals > GameManager.Instance.player_2_goals)
            {
                SceneManager.LoadSceneAsync(3);
            }
            else if (GameManager.Instance.player_1_goals < GameManager.Instance.player_2_goals)
            {
                SceneManager.LoadSceneAsync(2);
            }
            else if (GameManager.Instance.player_1_goals == GameManager.Instance.player_2_goals)
            {
                SceneManager.LoadSceneAsync(4);
            }

        }

    }
}
