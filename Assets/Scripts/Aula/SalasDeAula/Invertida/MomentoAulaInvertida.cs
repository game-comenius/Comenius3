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
        messenger.Init();
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
            if (midia.nomeMidia == NomeDeMidia.CadernosECartazes || midia.nomeMidia == NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas)
                pontuacao += 0.5f;
            else if (midia.nomeMidia == NomeDeMidia.Televisao)
                pontuacao += 0.17f;
            else
                pontuacao += 0.25f;
        }
        
        pontuacao /= quantidadeDeQuizzes;
        OnPontuacaoMidiaUpdate.Invoke(pontuacao);
    }
}
