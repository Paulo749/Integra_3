using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements;
using DialogueEditor;


public class Botao : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject liberar;
    [SerializeField] Animator anim;
    [SerializeField] NPCConversation conversa;
    

    

    private void OnMouseDown()
    {
        if (!PauseManager.instance.gamePausado)
        {
            if (gameObject.CompareTag("Constroi"))
            {
                obj.SetActive(true);
                gameObject.SetActive(false);
                ConversationManager.Instance.StartConversation(conversa);
                GameManager.instance.podeMover = false;
                GameManager.instance.conversaAtiva = true;

            }
            else if (gameObject.CompareTag("Objetivo"))
            {
                if(GameManager.instance.podeMover == true && GameManager.instance.conversaAtiva == false)
                {
                    obj.SetActive(false);
                    liberar.SetActive(true);
                    anim.SetTrigger("Glow");
                }
                
                
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
            else if (gameObject.CompareTag("ComeçaQuiz"))
            {
                gameObject.SetActive(false);
                Questoes.instance.ComeçaQuiz();
            }
            else if (gameObject.CompareTag("Sair"))
            {
                Application.Quit();
            }
            else if (!gameObject.CompareTag("Certa"))
            {
                Questoes.instance.MudaQuestao();
            }
            else if (gameObject.CompareTag("Start"))
            {
                GameManager.instance.StartGame();
            }
            
        }
        
        





    }


}
