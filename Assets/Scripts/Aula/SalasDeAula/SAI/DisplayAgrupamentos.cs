using UnityEngine;

public class DisplayAgrupamentos : MonoBehaviour
{
    [Header("Agrupamentos")]

    [SerializeField] private GameObject Individual;
    [SerializeField] private GameObject Duplas;
    [SerializeField] private GameObject PequenosGrupos;
    [SerializeField] private GameObject GrandesGrupos;
    [SerializeField] private GameObject SalaInteira;
    [SerializeField] private StateMachine controladorJogo;

    void OnEnable()
    {
        UpdateDisplay();
        controladorJogo.OnMediaChange.AddListener(UpdateDisplay);
    }

    void OnDisable()
    {
        controladorJogo.OnMediaChange.RemoveListener(UpdateDisplay);
    }

    public void UpdateDisplay()
    {
        Agrupamento agrupamento = controladorJogo.currentMedia.agrupamento;

        Individual.SetActive(false);
        Duplas.SetActive(false);
        PequenosGrupos.SetActive(false);
        GrandesGrupos.SetActive(false);
        SalaInteira.SetActive(false);

        switch (agrupamento)
        {
            case Agrupamento.FormatoU:
                SalaInteira.SetActive(true);
                break;
            case Agrupamento.Individual:
                Individual.SetActive(true);
                break;
            case Agrupamento.Duplas:
                Duplas.SetActive(true);
                break;
            case Agrupamento.PequenosGrupos:
                PequenosGrupos.SetActive(true);
                break;
            case Agrupamento.GrandesGrupos:
                GrandesGrupos.SetActive(true);
                break;
        }

    }
}
