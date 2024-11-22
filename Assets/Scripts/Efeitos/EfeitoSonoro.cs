using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoSonoro : MonoBehaviour
{
    public AudioSource som;



    private void OnMouseDown()
    {
        som.Play();
    }

}
