using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textDialogoAbp : MonoBehaviour
{
    private string[] textos = new string[4];
    public Text textoAlterador;
    private int indice;
    public GameObject[] botoes;

    void Start()
    {

        textos[0] = "O problema do projeto � multidimensional e altamente interativo, uma vez que insere os participantes em um processo de investiga��o estruturado em torno de quest�es complexas. Diante disso, a grande contribui��o dessa metodologia em sala de aula reside na �nfase ao processo de aprendizagem e na intera��o entre os estudantes.";
        textos[1] = "Por meio dos princ�pios de autonomia, pesquisa, a��o e reflex�o, o desenvolvimento de um projeto parte da defini��o de um tema, da proposi��o de desafios e do planejamento e execu��o de estrat�gias para o cumprimento das a��es propostas.\n \nPara tanto, o docente deve observar os seguintes aspectos: \n\n � Conte�do significativo: relev�ncia para os estudantes.\n\n � Perguntas instigantes: mobilizar o grupo para a investiga��o, apresentando diferentes possibilidades de solu��o. \n\n" +
"� Pesquisa e inova��o: consultar diferentes fontes especializadas, buscando resultados criativos e inovadores.\n \n" +
"� Valoriza��o do processo: Aspectos relacionais e cognitivos do processo s�o fundamentais para a vida dos estudantes.";

        textos[2] = "A sequ�ncia did�tica na aprendizagem baseada em projetos pode ser dividida em tr�s momentos:\n\n" +
"� Definir o escopo, Planejar as etapas do projeto: � o planejamento, feito n�o s� previamente, mas durante as primeiras aulas, contando com a participa��o dos alunos.\n\n" +
"� Executar �s a��es previstas, Monitorar o desenvolvimento do projeto: � o momento de pr�tica e execu��o do projeto, que deve ser realizado pelos alunos e acompanhado pelo professor.\n\n " +
"� Apresentar os resultados: De volta em sala de aula, agora os alunos devem apresentar suas an�lises e resultados. ";
        //
    }
    
    public void AtualizarTextos(int valor)
    {
        indice += valor;

        textoAlterador.text = textos[indice];
        if(indice == 2)
        {
            botoes[0].SetActive(false);
            botoes[1].SetActive(true);
        }
    }
}
