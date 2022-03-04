using UnityEngine;

public class MomentoAulaInvertida : MonoBehaviour
{
    [HideInInspector] public int score;

    [SerializeField] private EstadoDeAulaInvertida messenger;

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

    public Midia MidiaAtual()
    {
        return messenger.midiaAtual;
    }

    public void UpdateScore(int scoreDiff)
    {
        score += scoreDiff;
    }
}
