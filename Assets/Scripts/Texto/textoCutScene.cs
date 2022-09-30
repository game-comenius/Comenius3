using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textoCutScne : MonoBehaviour
{
    private string[] textosCutscene = new string[6];
    public TextMeshProUGUI[] textosMostrados = new TextMeshProUGUI[7];
    private int paginaAtual;
    public GameObject[] botaoVoltar;
    public GameObject[] baloes;
    public Image lurdinha;
    public GameObject lurdinhaDeLado;
    public GameObject lurdinhaDeFrente;
    public GameObject botaoPronto;
    public GameObject botaoFinal;
    public Image comenius;
    public Sprite[] comeniusPosicoes;
    enum ComeniusPos
    {       Cruzado, Maozinha,   }
    void Start()
    {
        textosCutscene[0] = "Olá, Jogador(a).\n Eu sou o Comenius e você \n está aqui com a missão de transformara \n educação da cidade! ";
        textosCutscene[1] = "Precisamos criar práticas didáticas mais ágeis,\n tornando os estudantes protagonistas no processo.\n Durante o jogo serão apresentadas três metodologias\n ativas que vão te ajudar nesta tarefa. ";
        textosCutscene[2] = "Para isso, você precisa estender os espaços de\n aprendizagem que existem para além das paredes da\n sala de aula e dos muros da escola";
        textosCutscene[3] = "Você pode utilizar os laboratórios, instigar os estudantes a pesquisar, realizar partes das atividades em casa,  levá-los à cidade para aprender de maneira envolvente e a partir de diferentes contextos.";
        textosCutscene[4] = "Você está pronto para começar\n jornada ? ";
        textosCutscene[5] = "Ótimo! Agora vamos juntos explorar os vários\n usos de mídias digitais na educação";

        textosMostrados[0].text = textosCutscene[paginaAtual];
    }

    public void AtualizarTextos(int valor)
    {
        paginaAtual += valor;
       
        if(paginaAtual > 0)
        {
            for (int i = 0; i < botaoVoltar.Length; i++)
            {
                botaoVoltar[i].SetActive(true);
            }
         
        }
        else
        {
            for (int i = 0; i < botaoVoltar.Length; i++)
            {
                botaoVoltar[i].SetActive(false);
            }
        }
        AtualizarBaloes();
    }

    private void AtualizarBaloes()
    {
        if (botaoPronto.activeInHierarchy)
        {
            botaoPronto.SetActive(false);      
        }

        if (botaoFinal.activeInHierarchy)
        {
            botaoFinal.SetActive(false);
        }

        AjustarComenius(paginaAtual);



        if (paginaAtual == 0 || paginaAtual == 4 || paginaAtual == 5)
        {
            for (int i = 0; i < baloes.Length; i++)
            {
                baloes[i].SetActive(false);
            }
            baloes[0].SetActive(true);
            textosMostrados[0].text = textosCutscene[paginaAtual];
            if(paginaAtual == 4)
            {
                botaoPronto.SetActive(true);
            }
            if(paginaAtual == 5)
            {
                botaoFinal.SetActive(true);
            }
        }

        if(paginaAtual == 1 || paginaAtual == 3)
        {
            for (int i = 0; i < baloes.Length; i++)
            {
                baloes[i].SetActive(false);
            }
            baloes[1].SetActive(true);
            textosMostrados[1].text = textosCutscene[paginaAtual];
        }

        if(paginaAtual == 2)
        {
            for (int i = 0; i < baloes.Length; i++)
            {
                baloes[i].SetActive(false);
            }
            baloes[2].SetActive(true);
            textosMostrados[2].text = textosCutscene[paginaAtual];
        }
    }

    private void AjustarComenius(int valor)
    {
        switch (valor)
        {
            case 0:
                comenius.sprite = comeniusPosicoes[(int)ComeniusPos.Maozinha];
                lurdinhaDeLado.SetActive(true);
                lurdinhaDeFrente.SetActive(false);
                break;

            case 1:
                comenius.sprite = comeniusPosicoes[(int)ComeniusPos.Cruzado];
                lurdinhaDeLado.SetActive(true);
                lurdinhaDeFrente.SetActive(false);
                break;

            case 2:
                comenius.sprite = comeniusPosicoes[(int)ComeniusPos.Cruzado];
                lurdinhaDeLado.SetActive(false);
                lurdinhaDeFrente.SetActive(true);
                break;

            case 3:
                comenius.sprite = comeniusPosicoes[(int)ComeniusPos.Cruzado];
                lurdinhaDeLado.SetActive(true);
                lurdinhaDeFrente.SetActive(false);
                break;

            case 4:
                comenius.sprite = comeniusPosicoes[(int)ComeniusPos.Maozinha];
                lurdinhaDeLado.SetActive(true);
                lurdinhaDeFrente.SetActive(false);
                break;

            case 5:
                comenius.sprite = comeniusPosicoes[(int)ComeniusPos.Cruzado];
                lurdinhaDeLado.SetActive(false);
                lurdinhaDeFrente.SetActive(true);
                break;

        }
      ;
    }
}
