using System.Collections.Generic;
using UnityEngine;

public class MidiasNoLaboratorioABP : MidiasNaSalaDeAula
{
    // Um campo para cada nome de mídia presente em Metodologia.ABP.NomesDeMidiasDaMetodologia()
    // As mídias do tipo software serão mostradas usando os aparelhosDigitaisParaMidiasTipoSoftware,
    // esses aparelhos representarão todas elas
    [SerializeField] GameObject lousa;
    [SerializeField] GameObject livrosDidaticos;
    [SerializeField] GameObject cadernosECartazes;
    [SerializeField] GameObject televisao;
    [SerializeField] GameObject consolesParaJogos;
    [SerializeField] GameObject projetorMultimidia;
    [SerializeField] GameObject aparelhosDigitaisParaMidiasTipoSoftware;

    private Dictionary<NomeDeMidia, GameObject> midiasNaSalaDeAulaPorNome;


    protected override void Awake()
    {
        base.Awake();

        midiasNaSalaDeAulaPorNome = new Dictionary<NomeDeMidia, GameObject>
        {
            { NomeDeMidia.Lousa, lousa },
            { NomeDeMidia.LivroDidatico, livrosDidaticos },
            { NomeDeMidia.CadernosECartazes, cadernosECartazes },
            { NomeDeMidia.Televisao, televisao },
            { NomeDeMidia.Jogos, consolesParaJogos },
            { NomeDeMidia.ProjetorMultimidia, projetorMultimidia },
            { NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas, aparelhosDigitaisParaMidiasTipoSoftware },
            { NomeDeMidia.EditoresDeAudioEVideo, aparelhosDigitaisParaMidiasTipoSoftware },
            { NomeDeMidia.Aplicativos, aparelhosDigitaisParaMidiasTipoSoftware },
            { NomeDeMidia.AVEAs, aparelhosDigitaisParaMidiasTipoSoftware },
        };

        // Esconder todas as mídias caso algumas delas ainda estejam visíveis
        foreach (var midiasNaSala in midiasNaSalaDeAulaPorNome.Values)
            midiasNaSala.SetActive(false);
    }

    public override bool MostrarMidiasNaSalaDeAula(NomeDeMidia nomeDeMidia)
    {
        // Por enquanto só é possível mostrar 1 mídia de cada vez, então
        // esconder qualquer mídia que esteja sendo mostrada na sala de aula
        base.EsconderMidiasNaSalaDeAula();

        var midiaPodeSerMostradaNestaSala = midiasNaSalaDeAulaPorNome.TryGetValue(nomeDeMidia, out GameObject midiasNaSala);

        if (midiaPodeSerMostradaNestaSala)
        {
            base.midiasVisiveis.Add(midiasNaSala);
            midiasNaSala.SetActive(true);
        }
        else
        {
            Debug.LogError($"O jogo não sabe como mostrar a mídia {new Midia(nomeDeMidia).NomeApresentavel} nesta sala de aula.");
        }

        return midiaPodeSerMostradaNestaSala;
    }

    // Por enquanto, as mídias não aparecerão juntas, mas é possível que apareçam no futuro
    public override bool MostrarMidiasNaSalaDeAula(NomeDeMidia[] nomeDeMidia)
    {
        throw new System.NotImplementedException();
    }
}
