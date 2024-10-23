using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;
using static UnityEngine.ParticleSystem;

public class ball : MonoBehaviour
{
    [SerializeField] private GameObject Ball_Start;
    [SerializeField] private GameObject Trail;
    [SerializeField] public Material material_1, material_2, material_3;
    private main_menu main_menu;

    // Start is called before the first frame update
    void Start()
    {
        if (main_menu.bouton_number == 1)
            GetComponent<Renderer>().material = material_2;
        else if (main_menu.bouton_number == 2)
            GetComponent<Renderer>().material = material_3;
        else if (main_menu.bouton_number == 3)
            GetComponent<Renderer>().material = material_1;
        else
            GetComponent<Renderer>().material = material_2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn_ball()
    {
        transform.position = Ball_Start.transform.position;
        transform.rotation = Ball_Start.transform.rotation;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
