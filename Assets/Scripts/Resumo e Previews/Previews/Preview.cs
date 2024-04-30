using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Preview : MonoBehaviour
{
    [HideInInspector] public int selectedOption;
    [HideInInspector] public Sprite quartoInfantil;
    [HideInInspector] public Sprite quartoFundamental;
    [HideInInspector] public Sprite quartoMedio;
    [HideInInspector] public Sprite quartoSuperior;
    [HideInInspector] public Sprite salaInfantilU;
    [HideInInspector] public Sprite salaInfantilIndividual;
    [HideInInspector] public Sprite salaInfantilDuplasETrios;
    [HideInInspector] public Sprite salaInfantilGrandesGrupos;
    [HideInInspector] public Sprite salaRegularU;
    [HideInInspector] public Sprite salaRegularIndividual;
    [HideInInspector] public Sprite salaRegularTrios;
    [HideInInspector] public Sprite salaRegularGrandesGrupos;
    [HideInInspector] public bool segundoAgrupamento;

    private Image imagemAlvo;

    private void OnEnable()
    {
        if (imagemAlvo == null)
        {
            imagemAlvo = GetComponent<Image>();
        }

        switch (selectedOption)
        {
            case 0:

                if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
                {
                    imagemAlvo.sprite = quartoInfantil;
                }
                else if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EnsinoFundamental())
                {
                    imagemAlvo.sprite = quartoFundamental;
                }
                else if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EnsinoMedio)
                {
                    imagemAlvo.sprite = quartoMedio;
                }
                else
                {
                    imagemAlvo.sprite = quartoSuperior;
                }

                break;
            case 1:

                if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
                {
                    imagemAlvo.sprite = salaInfantilIndividual;
                }
                else
                {
                    imagemAlvo.sprite = salaRegularIndividual;
                }

                break;
            case 2:

                if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
                {
                    int indice = segundoAgrupamento ? 3 : 2;

                    switch (EstadoDoJogo.Instance.Midias[indice].agrupamento)
                    {
                        case Agrupamento.FormatoU:
                            imagemAlvo.sprite = salaInfantilU;
                            break;
                        case Agrupamento.Individual:
                            imagemAlvo.sprite = salaInfantilIndividual;
                            break;
                        case Agrupamento.PequenosGrupos:
                            imagemAlvo.sprite = salaInfantilDuplasETrios;
                            break;
                        case Agrupamento.GrandesGrupos:
                            imagemAlvo.sprite = salaInfantilGrandesGrupos;
                            break;
                        default:
                            Debug.LogError("Agrupamento inválido");
                            break;
                    }
                }
                else
                {
                    int indice = segundoAgrupamento ? 3 : 2;

                    switch (EstadoDoJogo.Instance.Midias[indice].agrupamento)
                    {
                        case Agrupamento.FormatoU:
                            imagemAlvo.sprite = salaRegularU;
                            break;
                        case Agrupamento.Individual:
                            imagemAlvo.sprite = salaRegularIndividual;
                            break;
                        case Agrupamento.PequenosGrupos:
                            imagemAlvo.sprite = salaRegularTrios;
                            break;
                        case Agrupamento.GrandesGrupos:
                            imagemAlvo.sprite = salaRegularGrandesGrupos;
                            break;
                        default:
                            Debug.LogError("Agrupamento inválido");
                            break;
                    }
                }

                break;
            default:
                Debug.LogWarning("Falha na opção selecionada.");
                break;
        }
    }
}
