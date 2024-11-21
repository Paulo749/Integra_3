using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Construtor : MonoBehaviour
{
    public static Construtor instanceCons;

    public GameObject[] itens;
    public int desativadas;

    [SerializeField] protected GameObject botaoConstruir;

    
    private void Awake()
    {
        instanceCons = this;
        desativadas = 0;
        botaoConstruir.SetActive(false);
    }


    

    public void VerificaFilhos()
    {

        if (desativadas == 6) 
        {
            Debug.Log("ahs");
            botaoConstruir.SetActive(true);
        }
        
        
                                              
    }


}
