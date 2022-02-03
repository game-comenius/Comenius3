using UnityEngine;

public class DisplaySalaDeAulaInvertida : MonoBehaviour
{
    [SerializeField] private GameObject salaNormal;
    [SerializeField] private GameObject salaInfantil;
    [SerializeField] private EstadoDeAulaInvertida controladorJogo;

    void OnEnable()
    {
        UpdateDisplay();
        controladorJogo.OnStateChange.AddListener(UpdateDisplay);
    }

    void OnDisable()
    {
        controladorJogo.OnStateChange.RemoveListener(UpdateDisplay);
    }

    public void UpdateDisplay()
    {
        NivelDeEnsino nivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;

        if (nivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
        {
            salaInfantil.SetActive(true);
            salaNormal.SetActive(false);
        }
        else
        {
            salaInfantil.SetActive(false);
            salaNormal.SetActive(true);
        }
    }
}
