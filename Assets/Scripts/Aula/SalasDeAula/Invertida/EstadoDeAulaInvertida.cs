using System.Collections.Generic;
using UnityEngine;


//[CreateAssetMenu(fileName = "EstadoDeAulaInvertida", menuName = "Comenius3/EstadoDeAulaInvertida", order = 0)]
public class EstadoDeAulaInvertida : ScriptableObject
{
    public Midia midiaAtual;

    private int indiceEstadoAtual;

    public UnityEngine.Events.UnityEvent OnStateChange;
    public UnityEngine.Events.UnityEvent OnMidiaChange;

    [SerializeField] private List<EstadoDeAula> estados;
    [SerializeField] private int indiceDaSegundaMidia;

    public EstadoDeAula estadoAtual
    {
        get
        {
            return estados[indiceEstadoAtual];
        }
    }

    public void Init()
    {
        indiceEstadoAtual = estados.Count - 1;
        AvancarEstado();
    }

    public void AvancarEstado()
    {
        indiceEstadoAtual++;

        if (indiceEstadoAtual >= estados.Count)
        {
            indiceEstadoAtual = 0;
        }

        // Atualiza a midia conforme o momento de aula
        if (indiceEstadoAtual > indiceDaSegundaMidia)
        {
            midiaAtual = EstadoDoJogo.Instance.MidiasSelecionadas[3];
            OnMidiaChange.Invoke();
        }
        else
            midiaAtual = EstadoDoJogo.Instance.MidiasSelecionadas[2];

        OnStateChange.Invoke();
    }
}
