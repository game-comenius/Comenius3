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

        textos[0] = "O problema do projeto é multidimensional e altamente interativo, uma vez que insere os participantes em um processo de investigação estruturado em torno de questões complexas. Diante disso, a grande contribuição dessa metodologia em sala de aula reside na ênfase ao processo de aprendizagem e na interação entre os estudantes.";
        textos[1] = "Por meio dos princípios de autonomia, pesquisa, ação e reflexão, o desenvolvimento de um projeto parte da definição de um tema, da proposição de desafios e do planejamento e execução de estratégias para o cumprimento das ações propostas.\n \nPara tanto, o docente deve observar os seguintes aspectos: \n\n • Conteúdo significativo: relevância para os estudantes.\n\n • Perguntas instigantes: mobilizar o grupo para a investigação, apresentando diferentes possibilidades de solução. \n\n" +
"• Pesquisa e inovação: consultar diferentes fontes especializadas, buscando resultados criativos e inovadores.\n \n" +
"• Valorização do processo: Aspectos relacionais e cognitivos do processo são fundamentais para a vida dos estudantes.";

        textos[2] = "A sequência didática na aprendizagem baseada em projetos pode ser dividida em três momentos:\n\n" +
"• Definir o escopo, Planejar as etapas do projeto: é o planejamento, feito não só previamente, mas durante as primeiras aulas, contando com a participação dos alunos.\n\n" +
"• Executar às ações previstas, Monitorar o desenvolvimento do projeto: É o momento de prática e execução do projeto, que deve ser realizado pelos alunos e acompanhado pelo professor.\n\n " +
"• Apresentar os resultados: De volta em sala de aula, agora os alunos devem apresentar suas análises e resultados. ";
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
