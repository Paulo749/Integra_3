using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questoes : MonoBehaviour
{
    [SerializeField] protected int acertos;
    //[SerializeField] protected int
    [SerializeField] GameObject[] questoes;
    [SerializeField]protected int questaoAtual;
    [SerializeField] protected GameObject telaVitoria;
    [SerializeField] protected GameObject telaPerda;
    [SerializeField] protected GameObject botaoInicia;
    

    public static Questoes instance;

    private void Awake()
    {
        acertos = 0;
        instance = this;
        telaVitoria.SetActive(false); 
        telaPerda.SetActive(false);
        questaoAtual = 0;
    }

    private void Start()
    {

        foreach (GameObject obj in questoes) 
        {
            obj.SetActive(false);
        }
       
    }

    public void ReiniciaQuiz()
    {
        foreach (GameObject obj in questoes)
        {
            obj.SetActive(false);
        }
        acertos = 0;
        telaVitoria.SetActive(false);
        telaPerda.SetActive(false);
        questaoAtual = 0;
        botaoInicia.SetActive(true);
    }

    public void Come�aQuiz()
    {
       
        questoes[questaoAtual].SetActive(true);
    }

    public void VerificaAcertos()
    {
        if (acertos >= 5) 
        {
            telaVitoria.SetActive(true);
        }
        else
        {
            telaPerda.SetActive(true);
            
        }
    }

    public void AddAcerto()
    {
        acertos++;
        
    }

    public void MudaQuestao()
    {
        if (questaoAtual + 1 == questoes.Length)
        {
            VerificaAcertos();
            questoes[questaoAtual].SetActive(false);
        }
        else
        {
            questaoAtual++;
            questoes[questaoAtual].SetActive(true);
            questoes[questaoAtual - 1].SetActive(false);
        }

    }

}
