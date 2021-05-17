using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AgrupamentosSalaInvertidaComMidias : MonoBehaviour
{
    [Header("Telas")]
    public int tela;
    // tela denomida qual painel no canvas vai mostrar o objeto com esse script, deve der declarado no inspetor(as únicas opções válidas são 1 ou 2)

    [Header("Agrupamentos")]
    public GameObject agrupamentoSalaInteira;
    public GameObject agrupamentoGrandesGrupos;
    public GameObject agrupamentoPequenosGrupos;
    public GameObject agrupamentoDuplas;
    public GameObject agrupamentoIndividual;
    public int agrupamentoValor;
    GameObject agrupamentoVisualizado;
    public Text nomeDoAgrupamento;
    

    //Midias
    [Header("Mídias")]
    public GameObject lousa;
    public GameObject televisao;
    public GameObject projetorMultimidia;
    public GameObject livrosDidaticos;
    public GameObject computadorAplicativo;
    public GameObject computadorAVEA;
    public GameObject computadorEditorAudioVideo;
    public GameObject computadorEditorPlanilhaTexto;
    public GameObject computadorRedesSociais;
    public GameObject consolesParaJogos;
    public GameObject cadernosECartazes;
    public ImagemMaiorSelecionada imagemIconeDaMidia;

    public ReferenciaDeMidias referenciaDeMidias;//Para conseguir as midias do EstatoDeJogo
    NomeDeMidia midiaSelecionada1;
    NomeDeMidia midiaSelecionada2;
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

        //Obtendo a referência das mídias
        midiaSelecionada1 = referenciaDeMidias.midia1.NomeMidia;
        midiaSelecionada2 = referenciaDeMidias.midia2.NomeMidia;
        //Começo do Algorítimo
        midiaPossuiIndividual01 = false;
        midiaPossuiIndividual02 = false;
        if(tela == 1)
        {
            indiceDaMidia = 2;
        }
        if(tela == 2)
        {
            indiceDaMidia = 3;
        }
        //Dicionário das Midias

        midiaSelecionadaDic.Add(NomeDeMidia.Lousa, lousa);
        midiaSelecionadaDic.Add(NomeDeMidia.Televisao, televisao);
        midiaSelecionadaDic.Add(NomeDeMidia.ProjetorMultimidia, projetorMultimidia);
        midiaSelecionadaDic.Add(NomeDeMidia.LivroDidatico, livrosDidaticos);
        midiaSelecionadaDic.Add(NomeDeMidia.Aplicativos, computadorAplicativo);
        midiaSelecionadaDic.Add(NomeDeMidia.AVEAs, computadorAVEA);
        midiaSelecionadaDic.Add(NomeDeMidia.EditoresDeAudioEVideo, computadorEditorAudioVideo);
        midiaSelecionadaDic.Add(NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas, computadorEditorPlanilhaTexto);
        midiaSelecionadaDic.Add(NomeDeMidia.RedesSociais, computadorRedesSociais);
        midiaSelecionadaDic.Add(NomeDeMidia.Jogos, consolesParaJogos);
        midiaSelecionadaDic.Add(NomeDeMidia.CadernosECartazes, cadernosECartazes);

        //Se esse script estiver no objeto do primeiro painel ele pesquisa sobre a midia1. Caso contrário ele não se preocupasobre a midia1.
        if (tela == 1)
        {
            //Configurando o Icone dos Painel
            imagemIconeDaMidia.MudarSelecao(midiaSelecionada1);

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

            if(midiaSelecionada1 == NomeDeMidia.Aplicativos || midiaSelecionada1 == NomeDeMidia.AVEAs || midiaSelecionada1 == NomeDeMidia.EditoresDeAudioEVideo || midiaSelecionada1 == NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas || midiaSelecionada1 == NomeDeMidia.RedesSociais)
            {
                //Dicionário dos agrupamentos de Computadores        
                agrupamentoComputadorDic.Add(Agrupamento.Individual, computadorAgrupamentoIndividual);
                agrupamentoComputadorDic.Add(Agrupamento.FormatoU, computadorAgrupamentoSalaInteira);                  //////Ver a questão de qual é o nome da midia do computador e fazer duas versões(tela e midia 1 ou 2)
                agrupamentoComputadorDic.Add(Agrupamento.Duplas, computadorAgrupamentoDupla);
                agrupamentoComputadorDic.Add(Agrupamento.GrandesGrupos, computadorAgrupamentoGrandesGrupos);
                agrupamentoComputadorDic.Add(Agrupamento.PequenosGrupos, computadorAgrupamentoGruposPequenos);

                midiaPossuiIndividual01 = true;
            }
        }

        //Se esse script estiver no objeto do segundo painel ele pesquisa sobre a midia2. Caso contrário ele não se preocupasobre a midia2.
        if (tela == 2)
        {
            //Configurando o Icone dos Painel
            imagemIconeDaMidia.MudarSelecao(midiaSelecionada2);

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

            if (midiaSelecionada2 == NomeDeMidia.Aplicativos || midiaSelecionada2 == NomeDeMidia.AVEAs || midiaSelecionada2 == NomeDeMidia.EditoresDeAudioEVideo || midiaSelecionada2 == NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas || midiaSelecionada2 == NomeDeMidia.RedesSociais)
            {
                //Dicionário dos agrupamentos de Computadores        
                agrupamentoComputadorDic.Add(Agrupamento.Individual, computadorAgrupamentoIndividual);
                agrupamentoComputadorDic.Add(Agrupamento.FormatoU, computadorAgrupamentoSalaInteira);                  //////Ver a questão de qual é o nome da midia do computador e fazer duas versões(tela e midia 1 ou 2)
                agrupamentoComputadorDic.Add(Agrupamento.Duplas, computadorAgrupamentoDupla);
                agrupamentoComputadorDic.Add(Agrupamento.GrandesGrupos, computadorAgrupamentoGrandesGrupos);
                agrupamentoComputadorDic.Add(Agrupamento.PequenosGrupos, computadorAgrupamentoGruposPequenos);

                midiaPossuiIndividual02 = true;
            }
        }

        
        agrupamentoValor = 1;
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
                
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.FormatoU;
                if(tela == 1)
                {
                    //Ativar objeto de midia 1(no caso de mídias individuais ativar o objeto vazio na hierarquia)
                    MostrarMidiaSelecionada(midiaSelecionada1);

                    //Se midia 1 for uma midia individual ativar seu agrupamento específico
                    if (midiaPossuiIndividual01)
                    {
                        MostrarMidiaIndividual(midiaSelecionada1, Agrupamento.FormatoU, midiaIndividualVizualizada01);
                    }
                }
                
                if(tela == 2)
                {
                    //Ativar objeto de midia 2(no caso de mídias individuais ativar o bjeto vazio na hierarquia)
                    MostrarMidiaSelecionada(midiaSelecionada2);

                    //Se midia 2 for uma midia individual ativar seu agrupamento específico
                    if (midiaPossuiIndividual02)
                    {
                        MostrarMidiaIndividual(midiaSelecionada2, Agrupamento.FormatoU, midiaIndividualVizualizada02);
                    }
                }
                
                break;
            case 2:
                agrupamentoVisualizado = agrupamentoGrandesGrupos;
                nomeDoAgrupamento.text = "Grupos Grandes";
                
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.GrandesGrupos;

                if(tela == 1)
                {
                    //Se midia 1 for uma midia individual ativar seu agrupamento específico
                    if (midiaPossuiIndividual01)
                    {
                        MostrarMidiaIndividual(midiaSelecionada1, Agrupamento.GrandesGrupos, midiaIndividualVizualizada01);
                    }
                }
                                
                if(tela == 2)
                {
                    //Se midia 2 for uma midia individual ativar seu agrupamento específico
                    if (midiaPossuiIndividual02)
                    {
                        MostrarMidiaIndividual(midiaSelecionada2, Agrupamento.GrandesGrupos, midiaIndividualVizualizada02);
                    }
                }
                
                break;
            case 3:
                agrupamentoVisualizado = agrupamentoPequenosGrupos;
                nomeDoAgrupamento.text = "Trios";
                
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.PequenosGrupos;

                if(tela == 1)
                {
                    //Se midia 1 for uma midia individual ativar seu agrupamento específico
                    if (midiaPossuiIndividual01)
                    {
                        MostrarMidiaIndividual(midiaSelecionada1, Agrupamento.PequenosGrupos, midiaIndividualVizualizada01);
                    }
                }                

                if(tela == 2)
                {
                    //Se midia 2 for uma midia individual ativar seu agrupamento específico
                    if (midiaPossuiIndividual02)
                    {
                        MostrarMidiaIndividual(midiaSelecionada2, Agrupamento.PequenosGrupos, midiaIndividualVizualizada02);
                    }
                }
                
                break;
            case 4:
                agrupamentoVisualizado = agrupamentoDuplas;
                nomeDoAgrupamento.text = "Duplas";

                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.Duplas;

                if(tela == 1)
                {
                    //Se midia 1 for uma midia individual ativar seu agrupamento específico
                    if (midiaPossuiIndividual01)
                    {
                        MostrarMidiaIndividual(midiaSelecionada1, Agrupamento.Duplas, midiaIndividualVizualizada01);
                    }
                }
                
                if(tela == 2)
                {
                    //Se midia 2 for uma midia individual ativar seu agrupamento específico
                    if (midiaPossuiIndividual02)
                    {
                        MostrarMidiaIndividual(midiaSelecionada2, Agrupamento.Duplas, midiaIndividualVizualizada02);
                    }
                }
                
                break;
            case 5:
                agrupamentoVisualizado = agrupamentoIndividual;
                nomeDoAgrupamento.text = "Individual";
                
                EstadoDoJogo.Instance.MidiasSelecionadas[indiceDaMidia].agrupamento = Agrupamento.Individual;

                if(tela == 1)
                {
                    //Se midia 1 for uma midia individual ativar seu agrupamento específico
                    if (midiaPossuiIndividual01)
                    {
                        MostrarMidiaIndividual(midiaSelecionada1, Agrupamento.Individual, midiaIndividualVizualizada01);
                    }
                }
                
                if(tela == 2)
                {
                    //Se midia 2 for uma midia individual ativar seu agrupamento específico
                    if (midiaPossuiIndividual02)
                    {
                        MostrarMidiaIndividual(midiaSelecionada2, Agrupamento.Individual, midiaIndividualVizualizada02);
                    }
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

    //Método usado para achar os agrupamentos de cada midia indivual 
    void MostrarMidiaIndividual(NomeDeMidia midia, Agrupamento agrupamento, string agrupamentoAMostra)
    {
        switch (midia)
        {
            case NomeDeMidia.LivroDidatico:
                agrupamentoLivroDic[agrupamento].SetActive(true);
                agrupamentoAMostra = agrupamentoLivroDic[agrupamento].name;
                break;
            case NomeDeMidia.Aplicativos:
                agrupamentoComputadorDic[agrupamento].SetActive(true);
                agrupamentoAMostra = agrupamentoComputadorDic[agrupamento].name;
                break;
            case NomeDeMidia.AVEAs:
                agrupamentoComputadorDic[agrupamento].SetActive(true);
                agrupamentoAMostra = agrupamentoComputadorDic[agrupamento].name;
                break;
            case NomeDeMidia.EditoresDeAudioEVideo:
                agrupamentoComputadorDic[agrupamento].SetActive(true);
                agrupamentoAMostra = agrupamentoComputadorDic[agrupamento].name;
                break;
            case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                agrupamentoComputadorDic[agrupamento].SetActive(true);
                agrupamentoAMostra = agrupamentoComputadorDic[agrupamento].name;
                break;
            case NomeDeMidia.RedesSociais:
                agrupamentoComputadorDic[agrupamento].SetActive(true);
                agrupamentoAMostra = agrupamentoComputadorDic[agrupamento].name;
                break;
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
