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
        if (Textos.GetIdiomaSelecionado() == Idiomas.INGLES)
        {
            textosCutscene[0] = "Hello, Player.\n I'm Comenius, the father of Didactics. \n I'll show you how to better plan your \n classes with media. ";
            textosCutscene[1] = "And I'm professor Maria de Lourdes,\nbut you can call me Lurdinha.";
            textosCutscene[2] = "I've been learning a lot about the uses of new media in school planning, and I'm going to help you in this mission!";
            textosCutscene[3] = "We need to create more agile teaching practices and\r\n make students protagonists in the process. \r\nDuring the game, three active\r\n methodologies will be presented that will help you in this\r\n task.";
            textosCutscene[4] = "Here in the game you will extend the\nlearning spaces beyond the walls of the classroom and the walls of the school.";
            textosCutscene[5] = "To do this, you will be able to use the laboratories, encourage \r\n students to research, carry out parts of the activities \r\n at home, take them to the city to learn in an \r\nengaging way and from different contexts.";
            textosCutscene[6] = "Here you will create didactic sequences using 21st century media\n, planning with active methodologies and\n considering the multiple intelligences of your classes.";
            textosCutscene[7] = "Are you ready to begin \nnour journey?";
            textosCutscene[8] = "<b>Great!</b> So let's explore together the potential and the challenge of including digital media in education. Shall we go?";
        }
        else if(Textos.GetIdiomaSelecionado() == Idiomas.PORTUGUES)
        {
            textosCutscene[0] = "Ol�, Jogador(a).\n Eu sou o Comenius, o pai da Did�tica. \n Vou te mostrar como planejar melhor suas \n aulas com as m�dias. ";
            textosCutscene[1] = "E eu sou a professora Maria de Lourdes,\n mas pode me chamar de Lurdinha.";
            textosCutscene[2] = "Venho aprendendo muito sobre os usos das novas \nm�dias nos planejamentos escolares, e vou ajudar voc�\n nessa miss�o!";
            textosCutscene[3] = "Precisamos criar pr�ticas did�ticas mais �geis e\n tornar os estudantes protagonistas no processo. \nDurante o jogo ser�o apresentadas tr�s metodologias\n ativas que v�o te ajudar nesta tarefa.";
            textosCutscene[4] = "Aqui no jogo voc� vai estender os espa�os de\n aprendizagem para al�m das paredes da sala de aula e dos muros da escola.";
            textosCutscene[5] = "Para isso, voc� vai poder utilizar os laborat�rios, instigar os \n estudantes a pesquisar, realizar partes das atividades \n em casa, lev�-los � cidade para aprender de maneira \nenvolvente e a partir de diferentes contextos.";
            textosCutscene[6] = "Aqui voc� vai criar sequ�ncias did�ticas com as m�dias\n do s�culo XXI, planejando com metodologias ativas e \n considerando as intelig�ncias m�ltiplas das suas turmas.";
            textosCutscene[7] = "Voc� est� pronto(a) para come�ar \nnossa jornada?";
            textosCutscene[8] = "<b>�timo!</b> Ent�o  vamos juntos explorar o potencial e o \n desafio de incluir as m�dias digitais na educa��o. \nVamos l�?";
        }

        else
        {
            textosCutscene[0] = "Hola, jugador.\n Soy Comenius, el padre de la did�ctica. \n Te mostrar� c�mo planificar mejor tus \n clases con medios. ";
            textosCutscene[1] = "Y yo soy la profesora Mar�a de Lourdes,\npero puedes llamarme Lurdinha.";
            textosCutscene[2] = "He estado aprendiendo mucho sobre los usos de los nuevos medios en la planificaci�n escolar y �voy a ayudarte en esta misi�n!";
            textosCutscene[3] = "Necesitamos crear pr�cticas de ense�anza m�s �giles y\n hacer que los estudiantes sean protagonistas en el proceso. \nDurante el juego, se presentar�n tres\n metodolog�as activas que te ayudar�n en esta tarea.";
            textosCutscene[4] = "Aqu�, en el juego, extender�s los\nespacios de aprendizaje m�s all� de las paredes del aula y de la escuela.";
            textosCutscene[5] = "Para hacer esto, podr�s utilizar los laboratorios, animar \r\na los estudiantes a investigar,realizar partes\r\nde las actividades en casa, llevarlos a la ciudad\r\n para aprender de una manera \r\ninteractiva y de diferentes contextos.";
            textosCutscene[6] = "Aqu� crear�s secuencias did�cticas utilizando medios del siglo XXI\n, planificando con metodolog�as activas y\n considerando las inteligencias m�ltiples de tus clases.";
            textosCutscene[7] = "�Est�s listo para comenzar nuestro viaje?";
            textosCutscene[8] = "<b>�Genial!</b> As� que exploremos juntos el potencial y el desaf�o de incluir los medios digitales en la educaci�n. �Vamos?";
        }


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
