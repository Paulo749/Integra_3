using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

public class Botao : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject liberar;
    [SerializeField] Animator anim;
    

    

    private void OnMouseDown()
    {
        if (!PauseManager.instance.gamePausado)
        {
            if (gameObject.CompareTag("Constroi"))
            {
                obj.SetActive(true);
                gameObject.SetActive(false);

            }
            else if (gameObject.CompareTag("Objetivo"))
            {
                obj.SetActive(false);
                liberar.SetActive(true);
                anim.SetTrigger("Glow");
                //GameManager.instance.AvançaHist();
            }
            else if (gameObject.CompareTag("Certa"))
            {
                Questoes.instance.AddAcerto();
                Questoes.instance.MudaQuestao();
            }
            else if (gameObject.CompareTag("Papel"))
            {
                GameManager.instance.AbaixaPapel();
            }
            else if (!gameObject.CompareTag("Certa"))
            {
                Questoes.instance.MudaQuestao();
            }
        }
        
        





    }


}
