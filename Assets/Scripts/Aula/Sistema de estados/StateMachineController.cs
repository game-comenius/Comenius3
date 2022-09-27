using UnityEngine;
using UnityEngine.SceneManagement;

public class StateMachineController : MonoBehaviour
{
    [HideInInspector] public float score;

    [SerializeField] private StateMachine messenger;

    public ScoreBar scoreBar;
    [ContextMenu("Start")]
    private void Start()
    {
        messenger.Init();
        if (SceneManager.GetActiveScene().name == "Sala de Aula ABProj 1-3" || SceneManager.GetActiveScene().name == "CidadeFuncional")
        {
          score = EstadoDoJogo.Instance.score;
        }

    }

    [ContextMenu("Avançar Estado")]
    public void AdvanceState()
    {
        messenger.AdvanceState();
    }

    public Midia CurrentMedia()
    {
        if(SceneManager.GetActiveScene().name == "CidadeFuncional")
        {
            int valor = Random.Range(4, 6);
            return EstadoDoJogo.Instance.Midias[valor];
        }
        return messenger.currentMedia;
    }

    public void UpdateScore(int scoreDiff)
    {
        score += scoreDiff;

        EstadoDoJogo.Instance.AtualizarScore(scoreDiff);
    }
}
