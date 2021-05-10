using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AgrupamentosSalaInvertidaComMidias : MonoBehaviour
{

    public GameObject agrupamentoSalaInteira;
    public GameObject agrupamentoGrandesGrupos;
    public GameObject agrupamentoPequenosGrupos;
    public GameObject agrupamentoDuplas;
    public GameObject agrupamentoIndividual;
    public int agrupamentoValor;
    GameObject agrupamentoVisualizado;
    public Text nomeDoAgrupamento;
    public TextMeshProUGUI descricaoAgrupamento;

    //Midias
    [Header("Mídias")]
    public GameObject lousa;
    public GameObject televisao;
    public GameObject projetorMultimidia;
    public GameObject livrosDidaticos;
    public GameObject computadores;
    public GameObject consolesParaJogos;
    public GameObject cadernosECartazes;


    NomeDeMidia midiaSelecionada1;//Vai ser declarada manualmente para testar a cena. Uma vez que pudermos obter a informação do EstadoDeJogo isso deve mudar.
    NomeDeMidia midiaSelecionada2;//Vai ser declarada manualmente para testar a cena. Uma vez que pudermos obter a informação do EstadoDeJogo isso deve mudar.
    Dictionary<NomeDeMidia, GameObject> midiaSelecionadaDic = new Dictionary<NomeDeMidia, GameObject>();
    bool midiaPossuiIndividual01;
    bool midiaPossuiIndividual02;
    public string midiaIndividualVizualizada01;
    public string midiaIndividualVizualizada02;

    [Header("Agrupamento Livro Didático")]
    public GameObject livroAgrupamentoSalaInteira;
    public GameObject livroAgrupamentoIndividual;
    public GameObject livroAgrupamentoDupla;
    public GameObject livroAgrupamentoGruposPequenos;
    public GameObject livroAgrupamentoGrandesGrupos;
    Dictionary<Agrupamento, GameObject> agrupamentoLivroDic = new Dictionary<Agrupamento, GameObject>();

    [Header("Agrupamento Computadores")]
    public GameObject computadorAgrupamentoSalaInteira;
    public GameObject computadorAgrupamentoIndividual;
    public GameObject computadorAgrupamentoDupla;
    public GameObject computadorAgrupamentoGruposPequenos;
    public GameObject computadorAgrupamentoGrandesGrupos;
    Dictionary<Agrupamento, GameObject> agrupamentoComputadorDic = new Dictionary<Agrupamento, GameObject>();

    [Header("Agrupamento Consoles para Jogos")]
    public GameObject consoleParaJogoAgrupamentoSalaInteira;
    public GameObject consoleParaJogoAgrupamentoIndividual;
    public GameObject consoleParaJogoAgrupamentoDupla;
    public GameObject consoleParaJogoAgrupamentoGruposPequenos;
    public GameObject consoleParaJogoAgrupamentoGrandesGrupos;
    Dictionary<Agrupamento, GameObject> agrupamentoConsolesParaJogosDic = new Dictionary<Agrupamento, GameObject>();

    [Header("Agrupamento CadernosECartazes")]
    public GameObject cadernoECartazAgrupamentoSalaInteira;
    public GameObject cadernoECartazAgrupamentoIndividual;
    public GameObject cadernoECartazAgrupamentoDupla;
    public GameObject cadernoECartazAgrupamentoGruposPequenos;
    public GameObject cadernoECartazAgrupamentoGrandesGrupos;
    Dictionary<Agrupamento, GameObject> agrupamentoCadernoECartazDic = new Dictionary<Agrupamento, GameObject>();

    public int indiceDaMidia;

    void Start()
    {

        //Teste da cena
        midiaSelecionada1 = NomeDeMidia.CadernosECartazes;
        midiaSelecionada2 = NomeDeMidia.ProjetorMultimidia;
        //Começo do Algorítimo
        midiaPossuiIndividual01 = false;
        midiaPossuiIndividual02 = false;

        //Dicionário das Midias

        midiaSelecionadaDic.Add(NomeDeMidia.Lousa, lousa);
        midiaSelecionadaDic.Add(NomeDeMidia.Televisao, televisao);
        midiaSelecionadaDic.Add(NomeDeMidia.ProjetorMultimidia, projetorMultimidia);
        midiaSelecionadaDic.Add(NomeDeMidia.LivroDidatico, livrosDidaticos);
        //midiaSelecionadaDic.Add(NomeDeMidia., computadores); Qual é o nome da midia do computador? RedesSociais?
        midiaSelecionadaDic.Add(NomeDeMidia.Jogos, consolesParaJogos);
        midiaSelecionadaDic.Add(NomeDeMidia.CadernosECartazes, cadernosECartazes);

        if (midiaSelecionada1 == NomeDeMidia.LivroDidatico)
        {
            //Dicionário dos agrupamentos de LivroDidatico
            agrupamentoLivroDic.Add(Agrupamento.FormatoU, livroAgrupamentoSalaInteira);
            agrupamentoLivroDic.Add(Agrupamento.Individual, livroAgrupamentoIndividual);
            agrupamentoLivroDic.Add(Agrupamento.Duplas, livroAgrupamentoDupla);
            agrupamentoLivroDic.Add(Agrupamento.PequenosGrupos, livroAgrupamentoGruposPequenos);
            agrupamentoLivroDic.Add(Agrupamento.GrandesGrupos, livroAgrupamentoGrandesGrupos);

            midiaPossuiIndividual01 = true;
        }
        if (midiaSelecionada2 == NomeDeMidia.LivroDidatico)
        {
            //Dicionário dos agrupamentos de LivroDidatico
            agrupamentoLivroDic.Add(Agrupamento.FormatoU, livroAgrupamentoSalaInteira);
            agrupamentoLivroDic.Add(Agrupamento.Individual, livroAgrupamentoIndividual);
            agrupamentoLivroDic.Add(Agrupamento.Duplas, livroAgrupamentoDupla);
            agrupamentoLivroDic.Add(Agrupamento.PequenosGrupos, livroAgrupamentoGruposPequenos);
            agrupamentoLivroDic.Add(Agrupamento.GrandesGrupos, livroAgrupamentoGrandesGrupos);

            midiaPossuiIndividual02 = true;
        }

        //Dicionário dos agrupamentos de Computadores
        /*
        agrupamentoComputadorDic.Add(Agrupamento.Individual, computadorAgrupamentoIndividual);
        agrupamentoComputadorDic.Add(Agrupamento.FormatoU, computadorAgrupamentoSalaInteira);                  //////Ver a questão de qual é o nome da midia do computador
        agrupamentoComputadorDic.Add(Agrupamento.Duplas, computadorAgrupamentoDupla);
        agrupamentoComputadorDic.Add(Agrupamento.GrandesGrupos, computadorAgrupamentoGrandesGrupos);
        agrupamentoComputadorDic.Add(Agrupamento.PequenosGrupos, computadorAgrupamentoGrandesGrupos);*/

        if (midiaSelecionada1 == NomeDeMidia.Jogos)
        {
            //Dicionário de agrupamentos de ConsolesParaJogos
            agrupamentoConsolesParaJogosDic.Add(Agrupamento.Individual, consoleParaJogoAgrupamentoIndividual);
            agrupamentoConsolesParaJogosDic.Add(Agrupamento.FormatoU, consoleParaJogoAgrupamentoSalaInteira);
            agrupamentoConsolesParaJogosDic.Add(Agrupamento.Duplas, consoleParaJogoAgrupamentoDupla);
            agrupamentoConsolesParaJogosDic.Add(Agrupamento.GrandesGrupos, consoleParaJogoAgrupamentoGrandesGrupos);
            agrupamentoConsolesParaJogosDic.Add(Agrupamento.PequenosGrupos, consoleParaJogoAgrupamentoGruposPequenos);

            midiaPossuiIndividual01 = true;
        }

        if (midiaSelecionada2 == NomeDeMidia.Jogos)
        {
            //Dicionário de agrupamentos de ConsolesParaJogos
            agrupamentoConsolesParaJogosDic.Add(Agrupamento.Individual, consoleParaJogoAgrupamentoIndividual);
            agrupamentoConsolesParaJogosDic.Add(Agrupamento.FormatoU, consoleParaJogoAgrupamentoSalaInteira);
            agrupamentoConsolesParaJogosDic.Add(Agrupamento.Duplas, consoleParaJogoAgrupamentoDupla);
            agrupamentoConsolesParaJogosDic.Add(Agrupamento.GrandesGrupos, consoleParaJogoAgrupamentoGrandesGrupos);
            agrupamentoConsolesParaJogosDic.Add(Agrupamento.PequenosGrupos, consoleParaJogoAgrupamentoGruposPequenos);

            midiaPossuiIndividual02 = true;
        }

        if (midiaSelecionada1 == NomeDeMidia.CadernosECartazes)
        {
            //Dicionário de agrupamentos de CadernosECartazes
            agrupamentoCadernoECartazDic.Add(Agrupamento.Individual, cadernoECartazAgrupamentoIndividual);
            agrupamentoCadernoECartazDic.Add(Agrupamento.FormatoU, cadernoECartazAgrupamentoSalaInteira);
            agrupamentoCadernoECartazDic.Add(Agrupamento.Duplas, cadernoECartazAgrupamentoDupla);
            agrupamentoCadernoECartazDic.Add(Agrupamento.GrandesGrupos, cadernoECartazAgrupamentoGrandesGrupos);
            agrupamentoCadernoECartazDic.Add(Agrupamento.PequenosGrupos, cadernoECartazAgrupamentoGruposPequenos);

            midiaPossuiIndividual01 = true;
        }

        if (midiaSelecionada2 == NomeDeMidia.CadernosECartazes)
        {
            //Dicionário de agrupamentos de CadernosECartazes
            agrupamentoCadernoECartazDic.Add(Agrupamento.Individual, cadernoECartazAgrupamentoIndividual);
            agrupamentoCadernoECartazDic.Add(Agrupamento.FormatoU, cadernoECartazAgrupamentoSalaInteira);
            agrupamentoCadernoECartazDic.Add(Agrupamento.Duplas, cadernoECartazAgrupamentoDupla);
            agrupamentoCadernoECartazDic.Add(Agrupamento.GrandesGrupos, cadernoECartazAgrupamentoGrandesGrupos);
            agrupamentoCadernoECartazDic.Add(Agrupamento.PequenosGrupos, cadernoECartazAgrupamentoGruposPequenos);

            midiaPossuiIndividual02 = true;
        }

        MostrarAgrupamento(1);
    }

    public void MostrarAgrupamento(int agrValor)
    {
        if (agrupamentoVisualizado != null)
        {
            //Esconde o agrupamento que estva disponível antes de apertar o botão
            agrupamentoVisualizado.SetActive(false);
        }

        //Seleciona o próximo agrupamento de acordo com o int agrupamentoValor
        switch (agrValor)
        {
            case 1:
                agrupamentoVisualizado = agrupamentoSalaInteira;
                nomeDoAgrupamento.text = "Formato de U";
                descricaoAgrupamento.text = "Esse formato proporciona contato visual entre todos e favorece o debate coletivo, colaboração, troca entre os colegas, aulas expositivas que necessitam de apoio da lousa ou outra tecnologia educacional.";
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.FormatoU;
                //Ativar objeto de midia 1(no caso de mídias individuais ativar o objeto vazio na hierarquia)
                MostrarMidiaSelecionada(midiaSelecionada1);

                //Se midia 1 for uma midia individual ativar seu agrupamento específico
                if (midiaPossuiIndividual01)
                {
                    MostrarMidiaIndividual(midiaSelecionada1, Agrupamento.FormatoU, midiaIndividualVizualizada01);
                }

                //Ativar objeto de midia 2(no caso de mídias individuais ativar o bjeto vazio na hierarquia)
                MostrarMidiaSelecionada(midiaSelecionada2);

                //Se midia 2 for uma midia individual ativar seu agrupamento específico
                if (midiaPossuiIndividual02)
                {
                    MostrarMidiaIndividual(midiaSelecionada2, Agrupamento.FormatoU, midiaIndividualVizualizada02);
                }
                break;
            case 2:
                agrupamentoVisualizado = agrupamentoGrandesGrupos;
                nomeDoAgrupamento.text = "Grupos Grandes";
                descricaoAgrupamento.text = "Os grupos formados por um número maior de alunos são indicados para atividades de pluralidade de olhares e debate de hipóteses sobre o objeto de aprendizagem. Habilidades como negociação, argumentação, responsabilidade compartilhada, divisão e delegação de tarefas trabalhando em equipe.";
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.GrandesGrupos;

                //Se midia 1 for uma midia individual ativar seu agrupamento específico
                if (midiaPossuiIndividual01)
                {
                    MostrarMidiaIndividual(midiaSelecionada1, Agrupamento.GrandesGrupos, midiaIndividualVizualizada01);
                }

                //Ativar objeto de midia 2(no caso de mídias individuais ativar o bjeto vazio na hierarquia)
                MostrarMidiaSelecionada(midiaSelecionada2);

                //Se midia 2 for uma midia individual ativar seu agrupamento específico
                if (midiaPossuiIndividual02)
                {
                    MostrarMidiaIndividual(midiaSelecionada2, Agrupamento.GrandesGrupos, midiaIndividualVizualizada02);
                }
                break;
            case 3:
                agrupamentoVisualizado = agrupamentoPequenosGrupos;
                nomeDoAgrupamento.text = "Grupos Pequenos";
                descricaoAgrupamento.text = "";
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.PequenosGrupos;

                //Se midia 1 for uma midia individual ativar seu agrupamento específico
                if (midiaPossuiIndividual01)
                {
                    MostrarMidiaIndividual(midiaSelecionada1, Agrupamento.PequenosGrupos, midiaIndividualVizualizada01);
                }

                //Ativar objeto de midia 2(no caso de mídias individuais ativar o bjeto vazio na hierarquia)
                MostrarMidiaSelecionada(midiaSelecionada2);

                //Se midia 2 for uma midia individual ativar seu agrupamento específico
                if (midiaPossuiIndividual02)
                {
                    MostrarMidiaIndividual(midiaSelecionada2, Agrupamento.PequenosGrupos, midiaIndividualVizualizada02);
                }
                break;
            case 4:
                agrupamentoVisualizado = agrupamentoDuplas;
                nomeDoAgrupamento.text = "Duplas";
                descricaoAgrupamento.text = "Esse formato é recomendado para uma interação mais direta entre os alunos. Ideal para produção de textos, alfabetização e resolução de problemas.";
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.Duplas;

                //Se midia 1 for uma midia individual ativar seu agrupamento específico
                if (midiaPossuiIndividual01)
                {
                    MostrarMidiaIndividual(midiaSelecionada1, Agrupamento.Duplas, midiaIndividualVizualizada01);
                }

                //Ativar objeto de midia 2(no caso de mídias individuais ativar o bjeto vazio na hierarquia)
                MostrarMidiaSelecionada(midiaSelecionada2);

                //Se midia 2 for uma midia individual ativar seu agrupamento específico
                if (midiaPossuiIndividual02)
                {
                    MostrarMidiaIndividual(midiaSelecionada2, Agrupamento.Duplas, midiaIndividualVizualizada02);
                }
                break;
            case 5:
                agrupamentoVisualizado = agrupamentoIndividual;
                nomeDoAgrupamento.text = "Individual";
                descricaoAgrupamento.text = "Permite que o educador trabalhe aulas expositivas, apresentações em vídeo, filmes e situações em que é necessário o apoio da lousa. Essa organização em alguns momentos pode limitar a interação entre alunos e entre estes e os professores.";
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.Individual;

                //Se midia 1 for uma midia individual ativar seu agrupamento específico
                if (midiaPossuiIndividual01)
                {
                    MostrarMidiaIndividual(midiaSelecionada1, Agrupamento.Individual, midiaIndividualVizualizada01);
                }

                //Ativar objeto de midia 2(no caso de mídias individuais ativar o bjeto vazio na hierarquia)
                MostrarMidiaSelecionada(midiaSelecionada2);

                //Se midia 2 for uma midia individual ativar seu agrupamento específico
                if (midiaPossuiIndividual02)
                {
                    MostrarMidiaIndividual(midiaSelecionada2, Agrupamento.Individual, midiaIndividualVizualizada02);
                }
                break;

        }
        agrupamentoValor = agrValor;
        //Mostra o próximo agrupamento.
        agrupamentoVisualizado.SetActive(true);
    }

    public void BotaoProximoAgrupamento()
    {

        if (agrupamentoValor == 5)
        {
            agrupamentoValor = 0;
        }

        agrupamentoValor++;

        MostrarAgrupamento(agrupamentoValor);
    }

    public void BotaoAgrupamentoAnterior()
    {
        if (agrupamentoValor == 1)
        {
            agrupamentoValor = 6;
        }

        agrupamentoValor--;


        MostrarAgrupamento(agrupamentoValor);
    }

    //Método usado para ativar as Mídias
    void MostrarMidiaSelecionada(NomeDeMidia midia)
    {
        midiaSelecionadaDic[midia].SetActive(true);
    }

    //Método usado para achar os agrupamentos de cada midia indivual ///Terminar método
    void MostrarMidiaIndividual(NomeDeMidia midia, Agrupamento agrupamento, string agrupamentoAMostra)
    {
        switch (midia)
        {
            case NomeDeMidia.LivroDidatico:
                agrupamentoLivroDic[agrupamento].SetActive(true);
                agrupamentoAMostra = agrupamentoLivroDic[agrupamento].name;
                break;
            /*case NomeDeMidia.:
                agrupamentoLivroDic[agrupamento].SetActive(true);    ///Escolheria os agrupamentos da midia do computador
                break;*/
            case NomeDeMidia.Jogos:
                agrupamentoConsolesParaJogosDic[agrupamento].SetActive(true);
                agrupamentoAMostra = agrupamentoConsolesParaJogosDic[agrupamento].name;
                break;
            case NomeDeMidia.CadernosECartazes:
                agrupamentoCadernoECartazDic[agrupamento].SetActive(true);
                agrupamentoAMostra = agrupamentoCadernoECartazDic[agrupamento].name;
                break;
        }
    }
}
