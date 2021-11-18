using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayAgrupamentoComMidia : Pagina
{
    [Header("Midia Em Que o Script Vai Ser Focado")]
    public int midiaAlvo;
    
    //  denomida qual das duas midias da sala o script vai focar, deve der declarado no inspetor(as únicas opções válidas são 1 ou 2)

    [Header("Agrupamentos")]
    public GameObject agrupamentoSalaInteira;
    public GameObject agrupamentoGrandesGrupos;
    public GameObject agrupamentoPequenosGrupos;
    public GameObject agrupamentoDuplas;
    public GameObject agrupamentoIndividual;

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
    
    

    //public ReferenciaDeMidias referenciaDeMidias;//Para conseguir as midias do EstatoDeJogo
    Midia midiaSelecionada1;
    Midia midiaSelecionada2;
    bool possuiMidiaIndividual;
    Midia[] midiasDisponiveis = new Midia[3]; 
    Dictionary<NomeDeMidia, GameObject> midiaSelecionadaDic = new Dictionary<NomeDeMidia, GameObject>();
    
    //bool midiaPossuiIndividual02;    

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

    private void Start()
    {
        //Referencia das Midias
        // var estadoDeJogo = EstadoDoJogo.Instance;
        EstadoDoJogo estadoDoJogo = EstadoDoJogo.Instance;
        if (estadoDoJogo.MetodologiaSelecionada == Metodologia.Invertida)
        {
            midiaSelecionada1 = estadoDoJogo.MidiasSelecionadas[2];
            midiaSelecionada2 = estadoDoJogo.MidiasSelecionadas[3];

            //Começo do Algorítimo
            possuiMidiaIndividual = false;
            midiasDisponiveis[1] = midiaSelecionada1;
            midiasDisponiveis[2] = midiaSelecionada2;

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

            //Chacando se a midia é individual. Se for o caso ela vai ter que carregar outros dicionários
            if (midiasDisponiveis[midiaAlvo].nomeMidia == NomeDeMidia.LivroDidatico)
            {
                //Dicionário dos agrupamentos de LivroDidatico
                agrupamentoLivroDic.Add(Agrupamento.FormatoU, livroAgrupamentoSalaInteira);
                agrupamentoLivroDic.Add(Agrupamento.Individual, livroAgrupamentoIndividual);
                agrupamentoLivroDic.Add(Agrupamento.Duplas, livroAgrupamentoDupla);
                agrupamentoLivroDic.Add(Agrupamento.PequenosGrupos, livroAgrupamentoGruposPequenos);
                agrupamentoLivroDic.Add(Agrupamento.GrandesGrupos, livroAgrupamentoGrandesGrupos);

                possuiMidiaIndividual = true;
            }

            if (midiasDisponiveis[midiaAlvo].nomeMidia == NomeDeMidia.Jogos)
            {
                //Dicionário de agrupamentos de ConsolesParaJogos
                agrupamentoConsolesParaJogosDic.Add(Agrupamento.Individual, consoleParaJogoAgrupamentoIndividual);
                agrupamentoConsolesParaJogosDic.Add(Agrupamento.FormatoU, consoleParaJogoAgrupamentoSalaInteira);
                agrupamentoConsolesParaJogosDic.Add(Agrupamento.Duplas, consoleParaJogoAgrupamentoDupla);
                agrupamentoConsolesParaJogosDic.Add(Agrupamento.GrandesGrupos, consoleParaJogoAgrupamentoGrandesGrupos);
                agrupamentoConsolesParaJogosDic.Add(Agrupamento.PequenosGrupos, consoleParaJogoAgrupamentoGruposPequenos);

                possuiMidiaIndividual = true;
            }

            if (midiasDisponiveis[midiaAlvo].nomeMidia == NomeDeMidia.CadernosECartazes)
            {
                //Dicionário de agrupamentos de CadernosECartazes
                agrupamentoCadernoECartazDic.Add(Agrupamento.Individual, cadernoECartazAgrupamentoIndividual);
                agrupamentoCadernoECartazDic.Add(Agrupamento.FormatoU, cadernoECartazAgrupamentoSalaInteira);
                agrupamentoCadernoECartazDic.Add(Agrupamento.Duplas, cadernoECartazAgrupamentoDupla);
                agrupamentoCadernoECartazDic.Add(Agrupamento.GrandesGrupos, cadernoECartazAgrupamentoGrandesGrupos);
                agrupamentoCadernoECartazDic.Add(Agrupamento.PequenosGrupos, cadernoECartazAgrupamentoGruposPequenos);

                possuiMidiaIndividual = true;
            }

            if (midiasDisponiveis[midiaAlvo].nomeMidia == NomeDeMidia.Aplicativos || midiasDisponiveis[midiaAlvo].nomeMidia == NomeDeMidia.AVEAs || midiasDisponiveis[midiaAlvo].nomeMidia == NomeDeMidia.EditoresDeAudioEVideo || midiasDisponiveis[midiaAlvo].nomeMidia == NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas || midiasDisponiveis[midiaAlvo].nomeMidia == NomeDeMidia.RedesSociais)
            {
                //Dicionário dos agrupamentos de Computadores        
                agrupamentoComputadorDic.Add(Agrupamento.Individual, computadorAgrupamentoIndividual);
                agrupamentoComputadorDic.Add(Agrupamento.FormatoU, computadorAgrupamentoSalaInteira);
                agrupamentoComputadorDic.Add(Agrupamento.Duplas, computadorAgrupamentoDupla);
                agrupamentoComputadorDic.Add(Agrupamento.GrandesGrupos, computadorAgrupamentoGrandesGrupos);
                agrupamentoComputadorDic.Add(Agrupamento.PequenosGrupos, computadorAgrupamentoGruposPequenos);

                possuiMidiaIndividual = true;
            }

            //Ativar a os componentes da sala
            MostrarASala(midiasDisponiveis[midiaAlvo]);
            Debug.Log(midiaSelecionada1.agrupamento);
            Debug.Log(midiaSelecionada2.agrupamento);
        }
    }

    public void MostrarASala(Midia midia)
    {
        //Ativa o agrupamento dos alunos e se nescessário, das midias individuias.
        switch (midia.agrupamento)
        {
            case Agrupamento.Individual:
                //Mostrar alunos
                agrupamentoIndividual.SetActive(true);
                //Mostrar midia
                midiaSelecionadaDic[midia.nomeMidia].SetActive(true);
                //Se for uma midia individual
                if (possuiMidiaIndividual)
                {
                    MostrarMidiaIndividual(midiasDisponiveis[midiaAlvo], midiasDisponiveis[midiaAlvo].agrupamento);
                }
                break;
            case Agrupamento.Duplas:
                //Mostrar alunos
                agrupamentoDuplas.SetActive(true);
                //Mostrar midia
                midiaSelecionadaDic[midia.nomeMidia].SetActive(true);
                //Se for uma midia individual
                if (possuiMidiaIndividual)
                {
                    MostrarMidiaIndividual(midiasDisponiveis[midiaAlvo], midiasDisponiveis[midiaAlvo].agrupamento);
                }
                break;
            case Agrupamento.FormatoU:
                //Mostrar alunos
                agrupamentoSalaInteira.SetActive(true);
                //Mostrar midia
                midiaSelecionadaDic[midia.nomeMidia].SetActive(true);
                //Se for uma midia individual
                if (possuiMidiaIndividual)
                {
                    MostrarMidiaIndividual(midiasDisponiveis[midiaAlvo], midiasDisponiveis[midiaAlvo].agrupamento);
                }
                break;
            case Agrupamento.GrandesGrupos:
                //Mostrar alunos
                agrupamentoGrandesGrupos.SetActive(true);
                //Mostrar midia
                midiaSelecionadaDic[midia.nomeMidia].SetActive(true);
                //Se for uma midia individual
                if (possuiMidiaIndividual)
                {
                    MostrarMidiaIndividual(midiasDisponiveis[midiaAlvo], midiasDisponiveis[midiaAlvo].agrupamento);
                }
                break;
            case Agrupamento.PequenosGrupos:
                //Mostrar alunos
                agrupamentoPequenosGrupos.SetActive(true);
                //Mostrar midia
                midiaSelecionadaDic[midia.nomeMidia].SetActive(true);
                //Se for uma midia individual
                if (possuiMidiaIndividual)
                {
                    MostrarMidiaIndividual(midiasDisponiveis[midiaAlvo], midiasDisponiveis[midiaAlvo].agrupamento);
                }
                break;
        }
    }

    public void MostrarMidiaIndividual(Midia midia, Agrupamento agrupamento)
    {
        switch (midia.nomeMidia)
        {
            case NomeDeMidia.Aplicativos:
                agrupamentoComputadorDic[agrupamento].SetActive(true);
                break;
            case NomeDeMidia.AVEAs:
                agrupamentoComputadorDic[agrupamento].SetActive(true);
                break;
            case NomeDeMidia.CadernosECartazes:
                agrupamentoCadernoECartazDic[agrupamento].SetActive(true);
                break;
            case NomeDeMidia.EditoresDeAudioEVideo:
                agrupamentoComputadorDic[agrupamento].SetActive(true);
                break;
            case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                agrupamentoComputadorDic[agrupamento].SetActive(true);
                break;
            case NomeDeMidia.Jogos:
                agrupamentoConsolesParaJogosDic[agrupamento].SetActive(true);
                break;
            case NomeDeMidia.LivroDidatico:
                agrupamentoLivroDic[agrupamento].SetActive(true);
                break;            
        }
    }
}
