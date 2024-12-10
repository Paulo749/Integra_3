using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efeitos : MonoBehaviour
{
    public Texture2D cursorSpriteEncima;
    public Texture2D cursorSpriteFora;
    public GameObject contraste;

    private void Start()
    {
        Fora();
        DesativaContraste();
    }

    private void OnMouseOver()
    {
        if (!PauseManager.instance.gamePausado)
        {
            if (GameManager.instance.mapaAberto == false)
            {
                Encima();
                AtivaContraste();
                
            }
            else if (GameManager.instance.mapaAberto == true)
            {
                Fora();
                
            }
        }
        

    }

    private void OnMouseExit()
    {
        if (!PauseManager.instance.gamePausado) 
        {
            

            if (GameManager.instance.mapaAberto == false)
            {
                DesativaContraste();
                Fora();
                
            }
        }
        
    }

    void Fora()
    {
        Cursor.SetCursor(cursorSpriteFora, Vector2.zero, cursorMode: CursorMode.Auto);
    }

    void Encima()
    {
        Cursor.SetCursor(cursorSpriteEncima, Vector2.zero, cursorMode: CursorMode.Auto);
    }

    void AtivaContraste()
    {
        contraste.SetActive(true);
    }

    void DesativaContraste()
    {
        contraste.SetActive(false);
    }
}
