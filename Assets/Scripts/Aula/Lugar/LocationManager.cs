using UnityEngine;
using UnityEngine.UI;

public class LocationManager : MonoBehaviour
{
    [SerializeField] private Image mediaIcon;
    [SerializeField] private bool firstMedia;

    private void Start()
    {
        EstadoDoJogo gameState = EstadoDoJogo.Instance;

        if (firstMedia)
            mediaIcon.sprite = gameState.Midias[0].sprite;
        else
            mediaIcon.sprite = gameState.Midias[1].sprite;
    }
}
