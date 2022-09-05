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

    private GameObject currentPanel;
    private GameObject currentPanelGroup;

    private void Start()
    {
        // Inicializa os atributos
        currentPanel = defaultStartingPanel;
        currentPanelGroup = defaultStartingPanelGroup;

        if (SceneManager.GetActiveScene().name == "Menu" && EstadoDoJogo.Instance.FaseAtual > 0)
        {
            AdvanceLevel();
        }
    }

    public void ChangePanel(GameObject panel)
    {
        currentPanel.SetActive(false);
        panel.SetActive(true);
        currentPanel = panel;
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
        ChangePanelGroup(levelStartPanelGroup);
        ChangePanel(levelPanels[gameState.FaseAtual]);
    }
}
