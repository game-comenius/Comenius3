using UnityEngine;

public class StateMachineController : MonoBehaviour
{
    [HideInInspector] public int score;

    [SerializeField] private StateMachine messenger;

    [ContextMenu("Start")]
    private void Start()
    {
        messenger.Init();
    }

    [ContextMenu("Avançar Estado")]
    public void AdvanceState()
    {
        messenger.AdvanceState();
    }

    public Midia CurrentMedia()
    {
        return messenger.currentMedia;
    }

    public void UpdateScore(int scoreDiff)
    {
        score += scoreDiff;
    }
}
