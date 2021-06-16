using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MomentoAulaInvertida : MonoBehaviour
{ 
    [SerializeField]EstadoDeAulaInvertida messenger;
    [SerializeField]TrocadorDeCena trocadorDeCena;

    [System.Serializable] public class QuizzExitEvent : UnityEvent<float> { }
    public QuizzExitEvent OnPontuacaoMidiaUpdate;

    [ContextMenu("Start")]
    private void Start()
    {
        messenger.estadoAtual = EstadoDeAula.End;
        AvancarEstado();//Inicia o no primeiro estado e da a chamada de evento
        messenger.midiaAtual = EstadoDoJogo.Instance.MidiasSelecionadas[2];
    }


    [ContextMenu("Avançar Estado")]
    public void AvancarEstado()
    {
        messenger.AvancarEstado();
    }

    public void AtualizarPontuacaoDaAula(float quantidadeDeQuizzes)
    {
        

        EstadoDoJogo estadoJogo = EstadoDoJogo.Instance;
        Midia[] midiasSelecionadas = estadoJogo.MidiasSelecionadas;

        float pontuacao = 0f;

        foreach (Midia midia in midiasSelecionadas)
        {
            if (midia.NomeMidia == NomeDeMidia.CadernosECartazes || midia.NomeMidia == NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas)
                pontuacao += 0.5f;
            else if (midia.NomeMidia == NomeDeMidia.Televisao)
                pontuacao += 0.17f;
            else
                pontuacao += 0.25f;
        }
        
        pontuacao /= quantidadeDeQuizzes;
        OnPontuacaoMidiaUpdate.Invoke(pontuacao);
    }
}
