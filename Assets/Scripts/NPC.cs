using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class NPC : MonoBehaviour
{
    //public NPCConversation minhaConversaDefault;
    //public NPCConversation minhaConversa2;
    //public NPCConversation minhaConversa3;
    //public NPCConversation minhaConversa4;
    public NPCConversation minhaConversa;
    public Collider2D Collider;
    [SerializeField]protected GameObject conversa;



    private void Start()
    {
        if (conversa.CompareTag("ConversaInicial"))
        {
            ConversationManager.Instance.StartConversation(minhaConversa);
            
        }
        
    }


    protected void OnMouseOver()
    {
        if (!PauseManager.instance.gamePausado)
        {
            if (Input.GetMouseButtonDown(0) && GameManager.instance.conversaAtiva == false)
            {
                ConversationManager.Instance.StartConversation(minhaConversa);
                /*switch (GameManager.instance.historia)
                {
                    case 0:
                        ConversationManager.Instance.StartConversation(minhaConversa);
                        break;
                    case 1:
                        ConversationManager.Instance.StartConversation(minhaConversa2);
                        break;
                    case 2:
                        ConversationManager.Instance.StartConversation(minhaConversa2);
                        break;
                    default:                                    
                        ConversationManager.Instance.StartConversation(minhaConversaDefault);              
                        break;
                }*/

                Collider.enabled = false;
                GameManager.instance.podeMover = false;
                GameManager.instance.conversaAtiva = true;

                
            }
        }   
        

        

    }

    

    public void LigaHitBox()
    {
        Collider.enabled = true;
        GameManager.instance.conversaAtiva = false;
        GameManager.instance.podeMover = true;

    } 

    

   




}
