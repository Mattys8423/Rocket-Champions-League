using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reprendre : MonoBehaviour
{

    [SerializeField] static public bool Repris;
    [SerializeField] private bool DontDestroy;

    public void Start()
    {
        if (DontDestroy)
        {
            DontDestroyOnLoad(this.gameObject);
        }

        Repris = false;

    }

    public void resume()
    {
        SceneManager.LoadScene(1);
        Repris = true;
    }

    public void Menu()
    {
        Repris = false;
        SceneManager.LoadScene(0);
    }

}
