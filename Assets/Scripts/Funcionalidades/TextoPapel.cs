using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoPapel : MonoBehaviour
{
    [SerializeField] protected GameObject txtSelecionado;

    public void AtivaTxt()
    {
        GameManager.instance.PadraoTxt();
        txtSelecionado.SetActive(true);
    }




}
