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
    private GameObject currentPanel;

    private GameObject currentPanelGroup;
    private int faseEscolhida;

    private void Start()
    {
        // Inicializa os atributos
        currentPanel = defaultStartingPanel;
        currentPanelGroup = defaultStartingPanelGroup;

        if (SceneManager.GetActiveScene().name == "Menu" && EstadoDoJogo.Instance.FaseAtual > 0  && !EstadoDoJogo.Instance.menuGame|| EstadoDoJogo.Instance.telaSelecao && !EstadoDoJogo.Instance.menuGame)
        {        
            AdvanceLevel();
            return;
        }

        EstadoDoJogo.Instance.menuGame = false;
        EstadoDoJogo.Instance.telaSelecao = false;
    }

    public void ChangePanel(GameObject panel)
    {
        currentPanel.SetActive(false);
        panel.SetActive(true);
        currentPanel = panel;
    }

    public void FaseEscolhido(int fase)
    {

         EstadoDoJogo.Instance.FaseAtual = fase;
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
        if (gameState.menuGame)
        {
            ChangePanelGroup(panelEscolhaModo);
        }
        else
        {
            ChangePanelGroup(levelStartPanelGroup);

            ChangePanel(levelPanels[gameState.FaseAtual]);
        }
        panelIntro.SetActive(false);

        gameState.menuGame = false;
        gameState.telaSelecao = false;
    }
}
