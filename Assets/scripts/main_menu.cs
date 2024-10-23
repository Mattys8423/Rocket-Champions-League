using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{

    [SerializeField] bool DontDestroy;
    [SerializeField] public static int bouton_number;
    [SerializeField] public static float choose_time;
    [SerializeField] public static bool is_time;
    [SerializeField] Texture2D cursor;

    private void Start()
    {
        is_time = false;

        Cursor.visible = true;
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);

        if (DontDestroy)
        {
            DontDestroyOnLoad(this.gameObject);
        }

    }

    public void playgame()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void bouton_1()
    {
        bouton_number = 1;
    }

    public void bouton_2()
    {
        bouton_number = 2;
    }

    public void bouton_3()
    {
        bouton_number = 3;
    }

    public void time_options_1()
    {
        is_time = true;
        choose_time = 50f;
    }
    public void time_options_2()
    {
        is_time = true;
        choose_time = 100f;
    }
    public void time_options_3()
    {
        is_time = true;
        choose_time = 300f;
    }
}
