using UnityEngine;
using UnityEngine.UI;

public class ResumoAulaABP : MonoBehaviour
{
    [Header("Ícones")]
    [SerializeField] private Image iconeNivel;
    [SerializeField] private Image iconeArea;
    [SerializeField] private Image iconeInteligencia;
    [SerializeField] private Image iconeMetodologia;
    [SerializeField] private Image iconeLaboratorioMidia1;
    [SerializeField] private Image iconeLaboratorioMidia2;

    [Header("Textos")]
    [SerializeField] private Text textoNivel;
    [SerializeField] private Text textoArea;
    [SerializeField] private Text textoInteligencia;
    [SerializeField] private Text textoMetodologia;
    [SerializeField] private Text textoLaboratorioMidia1;
    [SerializeField] private Text textoLaboratorioMidia2;
    [SerializeField] private Text temaAula;
    private void Start()
    {
        // Sprites
        iconeNivel.sprite = EstadoDoJogo.Instance.NivelDeEnsino.sprite;
        iconeArea.sprite = EstadoDoJogo.Instance.AreaDeConhecimento.sprite;
        iconeInteligencia.sprite = EstadoDoJogo.Instance.Inteligencias.sprite;
        iconeMetodologia.sprite = EstadoDoJogo.Instance.Metodologia.sprite;
        iconeLaboratorioMidia1.sprite = EstadoDoJogo.Instance.Midias[0].sprite;
        iconeLaboratorioMidia2.sprite = EstadoDoJogo.Instance.Midias[1].sprite;

        NivelDeEnsino.TodosOsNiveisDeEnsino();
        AreaDeConhecimento.AtualizarTextosLinguas();
        Inteligencias.AtualizarTextosLinguas();
        Metodologia.AtualizarTextosLinguas();
   
        // Textos
        textoNivel.text = EstadoDoJogo.Instance.NivelDeEnsino.nome;
        textoArea.text = EstadoDoJogo.Instance.AreaDeConhecimento.nome;
        textoInteligencia.text = EstadoDoJogo.Instance.Inteligencias.nome;
        textoMetodologia.text = EstadoDoJogo.Instance.Metodologia.nome;
        textoLaboratorioMidia1.text = Midia.AtualizarTextosLinguas(EstadoDoJogo.Instance.Midias[0].nomeMidia, 2);
        textoLaboratorioMidia2.text = Midia.AtualizarTextosLinguas(EstadoDoJogo.Instance.Midias[1].nomeMidia, 2);
        temaAula.text = EstadoDoJogo.Instance.Tema;
    }
}
