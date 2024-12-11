using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspecionarDesativa : MonoBehaviour
{


    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        GameManager.instance.podeMover = true;
    }



}
