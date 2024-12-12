using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPC : MonoBehaviour
{
    //public NPCConversation minhaConversaDefault;
    public NPCConversation minhaConversa;
    public NPCConversation minhaConversa2;
    //public NPCConversation minhaConversa3;
    public NPCConversation ConversaInicial;
    public Collider2D Collider;
    [SerializeField]protected GameObject conversa;
    [SerializeField] protected GameObject proxObjetivo;
    [SerializeField] protected GameObject proxObjetivo2;
    [SerializeField] protected GameObject proxObjetivo3;
    [SerializeField] protected float tempFade;


    

    private void Start()
    {
        if (conversa.CompareTag("ConversaInicial"))
        {
            ConversationManager.Instance.StartConversation(ConversaInicial);
            Collider.enabled = false;
            GameManager.instance.podeMover = false;
            GameManager.instance.conversaAtiva = true;

        }
        
    }

    public void AtivaProxObjetivo()
    {
        proxObjetivo.SetActive(true);
    }

    public void AtivaProxObjetivo2()
    {
        proxObjetivo2.SetActive(true);
    }

    public void AtivaProxObjetivo3()
    {
        proxObjetivo3.SetActive(true);
    }


    public void AtivaSumir()
    {
        Invoke(nameof(Sumir), tempFade);
    }

    public void Sumir()
    {
        gameObject.SetActive(false);
    }

    protected void OnMouseOver()
    {
        if (!PauseManager.instance.gamePausado)
        {
            if (Input.GetMouseButtonDown(0) && GameManager.instance.conversaAtiva == false)
            {
                IniciaConversa();

                
            }
        }   
        

        

    }

    public void IniciaConversa()
    {
        //ConversationManager.Instance.StartConversation(minhaConversa);
        switch (GameManager.instance.historia)
        {
            case 0:
                ConversationManager.Instance.StartConversation(minhaConversa);
                break;
            case 1:
                ConversationManager.Instance.StartConversation(minhaConversa2);
                break;
                /*case 2:
                      ConversationManager.Instance.StartConversation(minhaConversa2);
                      break;
                  default:                                    
                      ConversationManager.Instance.StartConversation(minhaConversaDefault);              
                      break;*/
        }

        Collider.enabled = false;
        GameManager.instance.podeMover = false;
        GameManager.instance.conversaAtiva = true;
    }

    public void LigaHitBox()
    {
        Collider.enabled = true;
        GameManager.instance.conversaAtiva = false;
        GameManager.instance.podeMover = true;

    } 

    
    public void DesativaProxObjetivo()
    {
        proxObjetivo.SetActive(false);
    }

    public void DesativaProxObjetivo2()
    {
        proxObjetivo2.SetActive(false);
    }

    public void DesativaProxObjetivo3()
    {
        proxObjetivo3.SetActive(false);
    }






}
