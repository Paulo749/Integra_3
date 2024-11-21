using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item : MonoBehaviour
{
    


    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

        AH();

    }

    void AH()
    {
        if(gameObject.transform.position.y < -4.0f)
        {
            gameObject.SetActive(false);
            Construtor.instanceCons.desativadas++;
            SoundManager.instance.pegandoObj.Play();
            Construtor.instanceCons.VerificaFilhos();
        }
    }





}
