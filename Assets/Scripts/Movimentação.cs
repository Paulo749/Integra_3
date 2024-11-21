using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Movimentação : MonoBehaviour
{
    [SerializeField] protected GameObject cenaAlvo;
    [SerializeField] protected GameObject cenaAtual;
    //[SerializeField] protected GameObject[] botoesAtuais;
    //[SerializeField] protected GameObject[] botoesNovos;

    [SerializeField] protected SpriteRenderer imagem;

    private void Start()
    {
        imagem.enabled = false;
    }


    private void OnMouseExit()
    {
        if (!PauseManager.instance.gamePausado)
        {
            if (GameManager.instance.conversaAtiva == false)
            {
                imagem.enabled = false;
            }
        }
        
        
    }
    private void OnMouseEnter()
    {
        if (!PauseManager.instance.gamePausado)
        {
            if (GameManager.instance.conversaAtiva == false)
            {
                imagem.enabled = true;
            }
        }
        
    }

    private void OnMouseOver()
    {
        if (!PauseManager.instance.gamePausado)
        {
            if (Input.GetMouseButtonDown(0))
            {
                MudaCena();

            }
        }
           
    }



    public void MudaCena()
    {


        if (!PauseManager.instance.gamePausado)
        {
            if (GameManager.instance.podeMover == true)
            {

                cenaAtual.SetActive(false);
                cenaAlvo.SetActive(true);
                //botoesAtuais[].SetActive(false);
                //botoesNovos[].SetActive(true);


                imagem.enabled = false;

            }
        }
       
        


    }

    


}
