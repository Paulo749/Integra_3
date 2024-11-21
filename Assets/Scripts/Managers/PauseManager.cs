using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] protected GameObject TelaPause;
    public bool gamePausado;

    public static PauseManager instance;


    private void Awake()
    {
        instance = this;
        gamePausado = false;
        TelaPause.SetActive(false);
    }

    private void Update()
    {
        Inputs();
        
    }

    void Inputs()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && TelaPause.activeSelf == true)
        {
            TelaPause.SetActive(false);
            gamePausado = false;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && TelaPause.activeSelf == false) 
        {
            TelaPause.SetActive(true);
            gamePausado = true;
        }

    }

}
