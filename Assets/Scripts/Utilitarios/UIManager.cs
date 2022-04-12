using UnityEngine;
using UnityEngine.SceneManagement;

// Script para o controle dos painéis na interface

public class UIManager : MonoBehaviour
{
    // Atributos iniciais padrões
    [SerializeField] private GameObject defaultStartingPanel;
    // Um grupo de paineis se refere a um painel que contém outros painéis
    [SerializeField] private GameObject defaultStartingPanelGroup;
    [SerializeField] private GameObject secondLevelPanelGroup;
    [SerializeField] private GameObject secondLevelPanel;

    private GameObject currentPanel;
    private GameObject currentPanelGroup;

    private void Start()
    {
        // Inicializa os atributos
        currentPanel = defaultStartingPanel;
        currentPanelGroup = defaultStartingPanelGroup;

        if (SceneManager.GetActiveScene().name == "Menu" && EstadoDoJogo.Instance.FaseAtual == 1)
        {
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
