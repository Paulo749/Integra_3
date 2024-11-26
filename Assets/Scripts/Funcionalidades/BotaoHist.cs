using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoHist : MonoBehaviour
{



    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameManager.instance.AvancaHist();
        }
    }



}
