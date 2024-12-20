using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //[SerializeField] protected GameObject mapa;
    //[SerializeField] protected GameObject[] todosBotoes;
    //[SerializeField] protected GameObject todasCenas;
    //[SerializeField] protected GameObject[] icones;
    [SerializeField] protected GameObject[] cenas;
    public bool mapaAberto;
    protected GameObject cenaAtual;
    public bool podeMover;
    public bool conversaAtiva;
    [SerializeField] protected GameObject telaGameOver;
    [SerializeField] protected bool gameIniciado;
    

    public int historia;

    [SerializeField] Animator papel;
    [SerializeField] Animator fadeOut;
    [SerializeField] Animator antes;
    [SerializeField] SpriteRenderer antesNaMao;

    
    [SerializeField] GameObject[] cenaIniciais;
    [SerializeField] GameObject[] papelTxt;
    //[SerializeField] GameObject proxObjetivo;


    public static GameManager instance;


    
    public void AtivaMov()
    {
        conversaAtiva = false;
        podeMover = true;
    }

    private void Awake()
    {
        instance = this;
        historia = 0;
        gameIniciado = false;
        antesNaMao.enabled = false;


        foreach (GameObject obj in cenas)
        {
            obj.SetActive(false);
        }
        foreach(GameObject obj in cenaIniciais)
        {
            obj.SetActive(true);
        }
    }

    public void AvancaHist()
    {
        historia++;
    }

    public void PadraoTxt()
    {
        foreach(GameObject obj in papelTxt)
        {
            obj.SetActive(false);
        }
    }
    

    protected void Update()
    {
        Mapa();
        LocalizacaoNoMapa();
        
    }

    void LocalizacaoNoMapa()
    {
        /*if (mapaAberto == true)
        {
            for (int i = 0; i < cenas.Length; i++)
            {
                if (cenas[i].activeSelf == true)
                {
                    icones[i].SetActive(true);
                }
                else
                {
                    icones[i].SetActive(false);
                }

            }
        }*/
    }

    void PegarItem()
    {

    }
    #region animacao
    public void LevantaPapel()
    {
        papel.SetTrigger("Ativar");
        GameManager.instance.podeMover = false;
        GameManager.instance.conversaAtiva = true;
        //papel.SetBool("Levantado", true);
    }

    public void AbaixaPapel()
    {
        papel.SetTrigger("Desativar");
        GameManager.instance.podeMover = true;
        GameManager.instance.conversaAtiva = false;
        //papel.SetBool("Levantado", false);
    }

    public void FadeOut()
    {
        fadeOut.SetTrigger("Fade");
    }

    public void FadeLongo()
    {
        fadeOut.SetTrigger("FadeLongo");
    }

    public void AtivandoAntes()
    {
        antesNaMao.enabled = true;
        antes.SetTrigger("Ativando");
    }

    public void DesativaAntes()
    {
        antesNaMao.enabled = false;
    }

    #endregion

    protected void Start()
    {
        podeMover = true;
        //mapa.SetActive(false);
    }

    protected void Mapa()
    {
        /*if (mapa.activeSelf == true)
        {
            mapaAberto = true;
        }
        else if (mapa.activeSelf == false)
        {
            mapaAberto = false;
        }

        for (int i = 0; i < todosBotoes.Length; i++) 
        { 
            if (mapaAberto == false)
            {
                todosBotoes[i].SetActive(true);

            }
            else if (mapaAberto == true)
            {
                todosBotoes[i].SetActive(false);


            }
        }
        if (!PauseManager.instance.gamePausado)
        {
            if (Input.GetKeyDown(KeyCode.M) && historia > 0)
            {
                if (mapa.activeSelf == true)
                {
                    mapa.SetActive(false);
                    podeMover = true;
                    mapaAberto = false;



                }
                else if (mapa.activeSelf == false)
                {
                    mapa.SetActive(true);
                    podeMover = false;
                    mapaAberto = true;


                }

            }
        }*/
        
    }

    
   public void GameOver()
   {
       telaGameOver.SetActive(true);
   }
   public void StartGame()
   {
        historia = 0;
        gameIniciado = false;

        foreach (GameObject obj in cenas)
        {
            obj.SetActive(false);
        }
        foreach(GameObject obj in cenaIniciais)
        {
            obj.SetActive(true);
        }
   }
}
