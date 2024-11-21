using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questoes : MonoBehaviour
{
    [SerializeField] protected int acertos;
    //[SerializeField] protected int
    [SerializeField] GameObject[] questoes;
    protected int questaoAtual;
    [SerializeField] protected GameObject telaVitoria;
    [SerializeField] protected GameObject telaPerda;
    

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
            SoundManager.instance.zaWarudo.Play();
        }
    }

    public void AddAcerto()
    {
        acertos++;
        
    }

    public void MudaQuestao()
    {
        if (questaoAtual == 9)
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
