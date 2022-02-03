using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ControladorDisplayMomentoInteracao))]
public class SelecionadorDeMomentoDeInteracao : MonoBehaviour
{
    [SerializeField] private List<MomentoInteracao> imprevistos;
    [SerializeField] private List<MomentoInteracao> momentos;
    [SerializeField] private ControladorDisplayMomentoInteracao controlador;
    [SerializeField] private bool updateOnEnable = true;
    [SerializeField] private EstadoDeAulaInvertida controladorDaAula;
    [SerializeField] private bool cannotRepeat;
    private List<MomentoInteracao> momentosDisponiveis;
    private bool inicializarMomentosDisponiveis = true;

    private void OnEnable()
    {
        if (updateOnEnable)
            SelecionarImprevisto();
    }

    // Seleciona um momento de interação e evita que ele se repita.
    public void SelecionarImprevisto()
    {
        controlador.Momento = imprevistos[Random.Range(0, imprevistos.Count)];
    }

    public void SelecionarFeedback()
    {
        /* O método cria uma lista de momentos disponíveis com base no nível de ensino. Quando um
         * momento é escolhido é feita a remoção desse momento da lista de momentos disponíveis.
         * Quando a lista de momentos disponíveis fica vazia ela é inicializada novamente.
         */

        MomentoInteracao momento;
        NivelDeEnsino nivel = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;

        if (inicializarMomentosDisponiveis)
        {
            momentosDisponiveis = new List<MomentoInteracao>(momentos);
            inicializarMomentosDisponiveis = false;
        }

        momento = momentosDisponiveis[Random.Range(0, momentosDisponiveis.Count)];

        if (cannotRepeat)
        {
            momentosDisponiveis.Remove(momento);

            if (momentosDisponiveis.Count == 0)
            {
                momentosDisponiveis = null;
                inicializarMomentosDisponiveis = true;
            }
        }
        controlador.Momento = momento;
    }
}
