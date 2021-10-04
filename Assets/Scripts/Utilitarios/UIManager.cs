using UnityEngine;

// Script para o controle dos painéis na interface

public class UIManager : MonoBehaviour
{
    // Atributos iniciais padrões
    public GameObject defaultStartingPanel;
    // Um grupo de paineis se refere a um painel que contém outros painéis
    public GameObject defaultStartingPanelGroup;
    private GameObject currentPanel;
    private GameObject currentPanelGroup;

    private void Start()
    {
        // Inicializa os atributos
        currentPanel = defaultStartingPanel;
        currentPanelGroup = defaultStartingPanelGroup;
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
}
