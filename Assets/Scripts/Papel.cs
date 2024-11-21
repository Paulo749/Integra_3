using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Papel : MonoBehaviour
{
    [SerializeField] protected TextMeshPro[] textos;

    private void Update()
    {
        TextoAtivo();
    }

    private void OnMouseDown()
    {
        GameManager.instance.AbaixaPapel();

    }

    void TextoAtivo()
    {
        for (int i = 0; i < textos.Length; i++)
        {
            if (i == GameManager.instance.historia)
            {
                textos[i].gameObject.SetActive(true);
                
            }



        }




    }
}
