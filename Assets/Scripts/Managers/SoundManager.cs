using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource papel;
    public AudioSource pegandoObj;
    public AudioSource zaWarudo;
    


    public static SoundManager instance;


    private void Awake()
    {
        instance = this;
        
    }









}
