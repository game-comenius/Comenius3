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

        Debug.Log(EstadoDoJogo.Instance.Midias[0].nomeMidia);

        Debug.Log(EstadoDoJogo.Instance.Midias[1].nomeMidia);
        Debug.Log(EstadoDoJogo.Instance.Midias[2].nomeMidia);
        Debug.Log(EstadoDoJogo.Instance.Midias[3].nomeMidia);
        Debug.Log(EstadoDoJogo.Instance.Midias[4].nomeMidia);

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
          

         
            return EstadoDoJogo.Instance.Midias[PlayerPrefs.GetInt("random")];
        }
        return messenger.currentMedia;
    }

    public void UpdateScore(int scoreDiff)
    {
        score += scoreDiff;

        EstadoDoJogo.Instance.AtualizarScore(scoreDiff);
    }
}
