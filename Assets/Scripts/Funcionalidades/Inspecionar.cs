using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspecionar : MonoBehaviour
{
    [SerializeField] protected GameObject obj;


    private void Awake()
    {
        obj.SetActive(false);
    }

    private void OnMouseDown()
    {
        InspecionarItem();
    }

    protected void InspecionarItem()
    {  
        obj.SetActive(true);
        GameManager.instance.podeMover = false;        
    }

}
