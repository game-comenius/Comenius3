using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ControladorDisplayMomentoInteracao))]
public class SelecionadorDeMomentoDeInteracao : MonoBehaviour
{
    [SerializeField] private List<MomentoInteracao> momentos;
    [SerializeField] private List<MomentoInteracao> momentosInfantil;
    [SerializeField] private ControladorDisplayMomentoInteracao controlador;
    [SerializeField] private bool updateOnEnable = true;
    [SerializeField] private EstadoDeAulaInvertida controladorDaAula;
    [SerializeField] private bool cannotRepeat;
    private List<MomentoInteracao> momentosDisponiveis;
    bool inicializarMomentosDisponiveis = true;

    private void OnEnable()
    {
        controlador = gameObject.GetComponent<ControladorDisplayMomentoInteracao>();
        if (updateOnEnable)
            SelecionarMomento();
    }

    // Seleciona um momento de interação e evita que ele se repita.
    public void SelecionarMomento()
    {
        /* O método cria uma lista de momentos disponíveis com base no nível de ensino. Quando um
         * momento é escolhido é feita a remoção desse momento da lista de momentos disponíveis.
         * Quando a lista de momentos disponíveis fica vazia ela é inicializada novamente.
         */

        MomentoInteracao momento;
        NivelDeEnsino nivel = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;

        if (inicializarMomentosDisponiveis)
        {
            if (nivel == NivelDeEnsino.EducacaoInfantil)
            {
                momentosDisponiveis = new List<MomentoInteracao>(momentosInfantil);
            }
            else
            {
                momentosDisponiveis = new List<MomentoInteracao>(momentos);
            }

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

    public void SelecionarMomentoBaseadoEmMidia()
    {
        NomeDeMidia midia = controladorDaAula.midiaAtual.nomeMidia;
        NivelDeEnsino nivel = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;

        List<MomentoInteracao> possiveisMomentos = new List<MomentoInteracao>();
        List<MomentoInteracao> _momentos;
        if (nivel == NivelDeEnsino.EducacaoInfantil)
            _momentos = momentosInfantil;
        else
            _momentos = momentos;

        foreach (MomentoInteracao momento in _momentos)
        {
            foreach (NomeDeMidia _midia in momento.midias)
            {
                if (_midia == midia)
                    possiveisMomentos.Add(momento);
            }
        }

        if (possiveisMomentos.Count == 0)
            possiveisMomentos = _momentos;
        controlador.Momento = possiveisMomentos[Random.Range(0, possiveisMomentos.Count)];
    }

}
