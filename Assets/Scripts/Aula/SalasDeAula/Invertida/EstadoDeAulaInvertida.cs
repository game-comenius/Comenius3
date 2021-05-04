using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EstadoDeAulaInvertida", menuName = "Comenius3/EstadoDeAulaInvertida", order = 0)]
public class EstadoDeAulaInvertida : ScriptableObject 
{
    public Midia midiaAtual;
    [SerializeField]private EstadoDeAula _estadoAtual;
    public EstadoDeAula estadoAtual {
         get { return _estadoAtual; }
         set { _estadoAtual = 0;
            _estadoAtual = value; }
     }

    public UnityEngine.Events.UnityEvent OnStateChange;

    public UnityEngine.Events.UnityEvent OnMidiaChange;

    public void AvancarEstado()
    {
        estadoAtual = (EstadoDeAula)((int)estadoAtual << 1);

        if(estadoAtual > EstadoDeAula.End)
        {
            estadoAtual = EstadoDeAula.Quizz1;
        }
        //Atualiza a midia conforme o momento de aula
        if(estadoAtual > EstadoDeAula.Quizz2)
        {
            midiaAtual = EstadoDoJogo.Instance.MidiasSelecionadas[3];
            OnMidiaChange.Invoke();
        } else
            midiaAtual = EstadoDoJogo.Instance.MidiasSelecionadas[2];

        OnStateChange.Invoke();
    }
}
[System.Serializable, System.Flags]
    public enum EstadoDeAula{
        Quizz1 = (1 << 0),
        Interacao1 = (1 << 1),
        Quizz2 = (1 << 2),
        Interacao2 = (1 << 3),
        Quizz3 = (1 << 4),
        End=(1<<5)
    }
