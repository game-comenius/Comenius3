using UnityEngine;
using UnityEngine.UI;

public class ResumoAulaSAI : MonoBehaviour
{
    [Header("Ícones")]
    [SerializeField] private Image iconeNivel;
    [SerializeField] private Image iconeArea;
    [SerializeField] private Image iconeInteligencia;
    [SerializeField] private Image iconeMetodologia;
    [SerializeField] private Image iconeSalaMidia1;
    [SerializeField] private Image iconeSalaMidia2;
    [SerializeField] private Image iconeQuartoMidia1;
    [SerializeField] private Image iconeQuartoMidia2;

    [Header("Textos")]
    [SerializeField] private Text textoNivel;
    [SerializeField] private Text textoArea;
    [SerializeField] private Text textoInteligencia;
    [SerializeField] private Text textoMetodologia;
    [SerializeField] private Text textoSalaMidia1;
    [SerializeField] private Text textoSalaMidia2;
    [SerializeField] private Text textoQuartoMidia1;
    [SerializeField] private Text textoQuartoMidia2;
    [SerializeField] private Text textoAgrupamento1;
    [SerializeField] private Text textoAgrupamento2;

    private void Start()
    {
        // Sprites
        iconeNivel.sprite = EstadoDoJogo.Instance.NivelDeEnsino.sprite;
        iconeArea.sprite = EstadoDoJogo.Instance.AreaDeConhecimento.sprite;
        iconeInteligencia.sprite = EstadoDoJogo.Instance.Inteligencias.sprite;
        iconeMetodologia.sprite = EstadoDoJogo.Instance.Metodologia.sprite;
        iconeSalaMidia1.sprite = EstadoDoJogo.Instance.Midias[2].sprite;
        iconeSalaMidia2.sprite = EstadoDoJogo.Instance.Midias[3].sprite;
        iconeQuartoMidia1.sprite = EstadoDoJogo.Instance.Midias[0].sprite;
        iconeQuartoMidia2.sprite = EstadoDoJogo.Instance.Midias[1].sprite;

        // Textos
        textoNivel.text = EstadoDoJogo.Instance.NivelDeEnsino.nome;
        textoArea.text = EstadoDoJogo.Instance.AreaDeConhecimento.nome;
        textoInteligencia.text = EstadoDoJogo.Instance.Inteligencias.nome;
        textoMetodologia.text = EstadoDoJogo.Instance.Metodologia.nome;
        textoSalaMidia1.text = EstadoDoJogo.Instance.Midias[2].nome;
        textoSalaMidia2.text = EstadoDoJogo.Instance.Midias[3].nome;
        textoQuartoMidia1.text = EstadoDoJogo.Instance.Midias[0].nome;
        textoQuartoMidia2.text = EstadoDoJogo.Instance.Midias[1].nome;
        textoAgrupamento1.text = EstadoDoJogo.Instance.Midias[2].agrupamento.ToString(); // TODO: Arrumar
        textoAgrupamento2.text = EstadoDoJogo.Instance.Midias[3].agrupamento.ToString(); // TODO: Arrumar
    }
}
