using UnityEngine;
using UnityEngine.SceneManagement;

// Script para o controle dos painéis na interface

public class UIManager : MonoBehaviour
{
    // Atributos iniciais padrões
    public GameObject defaultStartingPanel;
    // Um grupo de paineis se refere a um painel que contém outros painéis
    public GameObject defaultStartingPanelGroup;
    private GameObject currentPanel;
    private GameObject currentPanelGroup;
    public GameObject secondLevelPanelGroup;
    public GameObject secondLevelPanel;

    private void Start()
    {
        // Inicializa os atributos
        currentPanel = defaultStartingPanel;
        currentPanelGroup = defaultStartingPanelGroup;

        if (SceneManager.GetActiveScene().name == "Menu" && EstadoDoJogo.Instance.FaseAtual == 1) {
            SecondLevel();
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

    public void SecondLevel()
    {
        //Change panel group.
        currentPanelGroup.SetActive(false);
        secondLevelPanelGroup.SetActive(true);
        currentPanelGroup = secondLevelPanelGroup;

        //Change panel.
        currentPanel.SetActive(false);
        secondLevelPanel.SetActive(true);
        currentPanel = secondLevelPanel;
    }
}
