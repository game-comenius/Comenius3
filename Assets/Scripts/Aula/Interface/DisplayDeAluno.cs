using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Image))]
public class DisplayDeAluno : MonoBehaviour
{
    public bool estaFeliz;

    [HideInInspector] public Aluno aluno;

    [SerializeField] private ListaDeAlunos alunos;
    [SerializeField] private bool atualizaOnStart;
    [SerializeField] private bool usaOutroDeReferencia;
    [SerializeField] private DisplayDeAluno outroDisplayRefencia;
    public Image imgAluno;
    public Image imgAlunoFrente;
    public Image imgRetratoAceitacao;
    public Sprite[] personagensSprite = new Sprite[3];
    public Sprite[] personagensFeliz = new Sprite[3];
    public Sprite[] personagensTristes = new Sprite[3];
    private int value;

    private void Start()
    {
        if (atualizaOnStart)
        {
            AtualizarAluno();
        }
    }

    public void AtualizarAluno()
    {
        if(SceneManager.GetActiveScene().name == "CidadeFuncional")
        {
            if (estaFeliz)
            {
                GetComponent<Image>().sprite = personagensFeliz[HoldImage.instance.valor];
            }
            else
            {
                GetComponent<Image>().sprite = personagensTristes[HoldImage.instance.valor];
            }
        }
        else
        {
            if (!usaOutroDeReferencia)
                aluno = alunos.GetAluno();
            else
                aluno = outroDisplayRefencia.aluno;
        }


        AtualizarDisplay();
    }
    private void OnEnable()
    {
        if (atualizaOnStart)
        {
            AtualizarAluno();
        }
    }

    public void AtualizarDisplay()
    {
     if(SceneManager.GetActiveScene().name != "CidadeFuncional")
        GetComponent<Image>().sprite = estaFeliz ? aluno.alunoFeliz : aluno.alunoTriste;
        /*
        if(SceneManager.GetActiveScene().name == "Sala de Aula ABProj 1-3")
        {
            if (imgAluno && imgAlunoFrente)
            {
                if (GameObject.Find("HoldImage").GetComponent<HoldImage>().valor >= 0)
                {
                    imgAluno.sprite = GameObject.Find("HoldImage").GetComponent<HoldImage>().personagensSprite[GameObject.Find("HoldImage").GetComponent<HoldImage>().valor];
                    imgAlunoFrente.sprite = GameObject.Find("HoldImage").GetComponent<HoldImage>().personagensSprite[GameObject.Find("HoldImage").GetComponent<HoldImage>().valor];
                }
                else
                {
                    imgAluno.sprite = GameObject.Find("HoldImage").GetComponent<HoldImage>().personagensSprite[0];
                    imgAlunoFrente.sprite = GameObject.Find("HoldImage").GetComponent<HoldImage>().personagensSprite[0];
                }

            }
        }
        */



    }

    IEnumerator tt()
    {
        yield return new WaitForSeconds(0.001f);
        GetComponent<Image>().sprite = personagensTristes[HoldImage.instance.valor];
    }


}
