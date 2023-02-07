using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;

// Script para o controle dos painéis na interface

public class UIManager : MonoBehaviour
{
    // Atributos iniciais padrões
    [SerializeField] private GameObject defaultStartingPanel;
    // Um grupo de paineis se refere a um painel que contém outros painéis
    [SerializeField] private GameObject defaultStartingPanelGroup;
    [SerializeField] private GameObject[] levelPanels;
    [SerializeField] private GameObject levelStartPanelGroup;

    [SerializeField] private GameObject panelEscolhaModo;
    [SerializeField] private GameObject panelIntro;
    [SerializeField] private GameObject planejamento;
    private GameObject currentPanel;
    private EstadoDoJogo estadoDoJogo;

    private GameObject currentPanelGroup;
    private int faseEscolhida;

    private void Start()
    {
        estadoDoJogo = EstadoDoJogo.Instance;
        // Inicializa os atributos
        currentPanel = defaultStartingPanel;
        currentPanelGroup = defaultStartingPanelGroup;

        if (SceneManager.GetActiveScene().name == "Menu" && estadoDoJogo.FaseAtual > 0  && !estadoDoJogo.menuGame|| estadoDoJogo.telaSelecao && !estadoDoJogo.menuGame || estadoDoJogo.jogarNovamente)
        {        
            AdvanceLevel();
            return;
        }
        estadoDoJogo.jogarNovamente = false;
        estadoDoJogo.menuGame = false;
        estadoDoJogo.telaSelecao = false;
    }

    public void ChangePanel(GameObject panel)
    {
        currentPanel.SetActive(false);
        panel.SetActive(true);
        currentPanel = panel;
    }

    public void FaseEscolhido(int fase)
    {
        estadoDoJogo.FaseAtual = fase;
        faseEscolhida = fase;
  
    }

    public void ModoEscolhido(bool status)
    {
        EstadoDoJogo.Instance.SetarModoDeJogo(status);
    }


    public void ChangePanelGroup(GameObject mainPanel)
    {
        currentPanelGroup.SetActive(false);
        mainPanel.SetActive(true);
        currentPanelGroup = mainPanel;
    }

    public void AdvanceLevel()
    {
        EstadoDoJogo gameState = EstadoDoJogo.Instance;
        if (gameState.telaSelecao)
        {
            Debug.Log("entrei tela selecao");
            ChangePanelGroup(planejamento);
            ChangePanel(panelEscolhaModo);
        }
        else
        {
            Debug.Log("Panel fase");
            ChangePanelGroup(levelStartPanelGroup);
            ChangePanel(levelPanels[gameState.FaseAtual]);
        }
        panelIntro.SetActive(false);

        gameState.jogarNovamente = false;
        gameState.menuGame = false;
        gameState.telaSelecao = false;
    }
}
