using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LocationManager : MonoBehaviour
{
    [SerializeField] private Image mediaIcon;
    [SerializeField] private Image locationPreview;
    [SerializeField] private TextMeshProUGUI locationText;
    [SerializeField] private bool firstMedia;

    /*  Essa solução não é boa, porém a melhor alternativa seria um replanejamento da maneira em que os lugares são
        representados no código. Para possíveis extensões futuras recomenda-se que seja criada uma classe que
        represente o lugar, juntamente com os enumeradores para facilitar na comparação.
    */
    [Header("Sprites dos lugares")]
    [SerializeField] private Sprite observatorySprite;
    [SerializeField] private Sprite circusSprite;
    [SerializeField] private Sprite aquariumSprite;
    [SerializeField] private Sprite theaterSprite;
    [SerializeField] private Sprite librarySprite;
    [SerializeField] private Sprite museumSprite;
    [SerializeField] private Sprite parkSprite;
    [SerializeField] private Sprite radioSprite;
    [SerializeField] private Sprite universitySprite;
    [SerializeField] private Sprite cinemaSprite;
    [SerializeField] private Sprite gymSprite;
    [SerializeField] private Sprite musicalSprite;
    [SerializeField] private Sprite researchCenterSprite;
    [SerializeField] private Sprite startupSprite;
    [SerializeField] private Sprite botanicalGardenSprite;
    [SerializeField] private Sprite NGOSprite;

    private void Start()
    {
        EstadoDoJogo gameState = EstadoDoJogo.Instance;

        if (firstMedia)
            mediaIcon.sprite = gameState.Midias[0].sprite;
        else
            mediaIcon.sprite = gameState.Midias[1].sprite;

        gameState.Lugar = LocationChecker.EvaluateLocation();
        string locationName = LocationChecker.EvaluateLocationName();

        locationText.text = $"Os estudantes escolheram fazer o projeto no <color=blue>{locationName}</color>";

        // ¯\_(ツ)_/¯
        switch (gameState.Lugar)
        {
            case LocationChecker.Location.Observatory:
                locationPreview.sprite = observatorySprite;
                break;
            case LocationChecker.Location.Circus:
                locationPreview.sprite = circusSprite;
                break;
            case LocationChecker.Location.Aquarium:
                locationPreview.sprite = aquariumSprite;
                break;
            case LocationChecker.Location.Theater:
                locationPreview.sprite = theaterSprite;
                break;
            case LocationChecker.Location.Library:
                locationPreview.sprite = librarySprite;
                break;
            case LocationChecker.Location.Museum:
                locationPreview.sprite = museumSprite;
                break;
            case LocationChecker.Location.Park:
                locationPreview.sprite = parkSprite;
                break;
            case LocationChecker.Location.Radio:
                locationPreview.sprite = radioSprite;
                break;
            case LocationChecker.Location.University:
                locationPreview.sprite = universitySprite;
                break;
            case LocationChecker.Location.Cinema:
                locationPreview.sprite = cinemaSprite;
                break;
            case LocationChecker.Location.Gym:
                locationPreview.sprite = gymSprite;
                break;
            case LocationChecker.Location.Musical:
                locationPreview.sprite = musicalSprite;
                break;
            case LocationChecker.Location.ResearchCenter:
                locationPreview.sprite = researchCenterSprite;
                break;
            case LocationChecker.Location.Startup:
                locationPreview.sprite = startupSprite;
                break;
            case LocationChecker.Location.BotanicalGarden:
                locationPreview.sprite = botanicalGardenSprite;
                break;
            case LocationChecker.Location.NGO:
                locationPreview.sprite = NGOSprite;
                break;
        }
    }
}
