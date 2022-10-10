using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textoCutScne : MonoBehaviour
{
    private string[] textosCutscene = new string[9];
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

    enum BaloesNames
    { ComeniusCurto,  ComeniusMedio, Lurdinha }
    void Start()
    {

        textosCutscene[0] = "Olá, Jogador(a).\n Eu sou o Comenius, o pai da Didática. \n Vou te mostrar como planejar melhor suas \n aulas com as mídias. ";
        textosCutscene[1] = "E eu sou a professora Maria de Lourdes,\n mas pode me chamar de Lurdinha.";
        textosCutscene[2] = "Venho aprendendo muito sobre os usos das novas \nmídias nos planejamentos escolares, e vou ajudar você\n nessa missão!";
        textosCutscene[3] = "Precisamos criar práticas didáticas mais ágeis e\n tornar os estudantes protagonistas no processo. \nDurante o jogo serão apresentadas três metodologias ativas que vão te ajudar nesta tarefa.";
        textosCutscene[4] = "Aqui no jogo você vai estender os espaços de\n aprendizagem para além das paredes da sala de aula e dos muros da escola.";
        textosCutscene[5] = "Para isso, você vai poder utilizar os laboratórios, instigar os \n estudantes a pesquisar, realizar partes das atividades \n em casa, levá-los à cidade para aprender de maneira \nenvolvente e a partir de diferentes contextos.";
        textosCutscene[6] = "Aqui você vai criar sequências didáticas com as mídias\n do século XXI, planejando com metodologias ativas e \n considerando as inteligências múltiplas das suas turmas.";
        textosCutscene[7] = "Você está pronto(a) para começar \nnossa jornada?";
        textosCutscene[8] = "<u><b>Ótimo!</b></u> Então  vamos juntos explorar o potencial e o \n desafio de incluir as mídias digitais na educação. \nVamos lá?";

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

        AjustarSprites(paginaAtual);



        if (paginaAtual == 0 || paginaAtual == 7 || paginaAtual == 8)
        {
            for (int i = 0; i < baloes.Length; i++)
            {
                baloes[i].SetActive(false);
            }
            baloes[0].SetActive(true);
            textosMostrados[0].text = textosCutscene[paginaAtual];
            if(paginaAtual == 7)
            {
                botaoPronto.SetActive(true);
            }
            if(paginaAtual == 8)
            {
                botaoFinal.SetActive(true);
            }
        }

        if(paginaAtual == 1 || paginaAtual == 2 || paginaAtual == 4 || paginaAtual == 6 || paginaAtual == 8)
        {
            for (int i = 0; i < baloes.Length; i++)
            {
                baloes[i].SetActive(false);
            }
            baloes[(int)BaloesNames.Lurdinha].SetActive(true);
            textosMostrados[(int)BaloesNames.Lurdinha].text = textosCutscene[paginaAtual];
        }

        if(paginaAtual == 3 || paginaAtual == 5 )
        {
            for (int i = 0; i < baloes.Length; i++)
            {
                baloes[i].SetActive(false);
            }
            baloes[(int)BaloesNames.ComeniusMedio].SetActive(true);
            textosMostrados[(int)BaloesNames.ComeniusMedio].text = textosCutscene[paginaAtual];
        }
    }

    private void AjustarSprites(int valor)
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
                lurdinhaDeLado.SetActive(false);
                lurdinhaDeFrente.SetActive(true);
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
                comenius.sprite = comeniusPosicoes[(int)ComeniusPos.Cruzado];
                lurdinhaDeLado.SetActive(false);
                lurdinhaDeFrente.SetActive(true);
                break;

            case 5:
                comenius.sprite = comeniusPosicoes[(int)ComeniusPos.Cruzado];
                lurdinhaDeLado.SetActive(true);
                lurdinhaDeFrente.SetActive(false);
                break;

            case 6:
                comenius.sprite = comeniusPosicoes[(int)ComeniusPos.Cruzado];
                lurdinhaDeLado.SetActive(false);
                lurdinhaDeFrente.SetActive(true);
                break;


            case 7:
                comenius.sprite = comeniusPosicoes[(int)ComeniusPos.Maozinha];
                lurdinhaDeLado.SetActive(true);
                lurdinhaDeFrente.SetActive(false);
                break;


            case 8:
                comenius.sprite = comeniusPosicoes[(int)ComeniusPos.Cruzado];
                lurdinhaDeLado.SetActive(false);
                lurdinhaDeFrente.SetActive(true);
                break;

        }
      ;
    }
}
