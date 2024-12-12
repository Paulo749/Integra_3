using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource papel;
    public AudioSource pegandoObj;
    public AudioSource zaWarudo;
    public AudioSource tiro;
    


    public static SoundManager instance;


    private void Awake()
    {
        instance = this;
        
    }

    public void PlayZawarudo()
    {
        zaWarudo.Play();
    }

    public void Tiro()
    {
        tiro.Play();
    }





}
