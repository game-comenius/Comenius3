using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClassFeedback : MonoBehaviour
{
    [SerializeField] private StateMachineController controller;
    [SerializeField] private TextMeshProUGUI classQualityText;
    [SerializeField] private Slider classQualityBar;
    [SerializeField] private float animationTime;
    [SerializeField] private TextMeshProUGUI comboClassificationText;
    [SerializeField] private TextMeshProUGUI comboText;
    [SerializeField] private List<string> specificFeedbacks;
    [SerializeField] private Image methodologyIcon;
    [SerializeField] private Image media1Icon;
    [SerializeField] private Image media2Icon;

    private void OnEnable()
    {
        string greetings;
        string adjective;  // TODO: Mudar isso aqui em relação as metodologias

        if (controller.score < 33)
        {
            greetings = "";
            adjective = "Confusa";
        }
        else if (controller.score < 66)
        {
            greetings = "";
            adjective = "Comum";
        }
        else
        {
            greetings = "Parabéns! ";
            adjective = "Reveladora";
        }

        // TODO: Modificar a fase no texto no futuro
        classQualityText.text = $"{greetings}Sua Aula foi {adjective}";

        StartCoroutine(UpdateBarCoroutine(controller.score));

        ComboChecker.Combo combo = ComboChecker.EvaluateCombo();

        string comboClassification;

        switch (combo)
        {
            case ComboChecker.Combo.Ideal:
                comboClassification = "IDEAL";
                break;
            case ComboChecker.Combo.Boa:
                comboClassification = "BOA";
                break;
            case ComboChecker.Combo.Arriscada:
                comboClassification = "ARRISCADA";
                break;
            default:
                comboClassification = "[ERRO]";
                break;
        }

        comboClassificationText.text = $"Para a {EstadoDoJogo.Instance.MetodologiaSelecionada.nome}, sua combinação de mídias foi {comboClassification}";

        // TODO: Calcular o índice do combo
        int comboIndex = 0;

        comboText.text = specificFeedbacks[comboIndex];

        methodologyIcon.sprite = EstadoDoJogo.Instance.MetodologiaSelecionada.sprite;
        media1Icon.sprite = EstadoDoJogo.Instance.MidiasSelecionadas[2].sprite;
        media2Icon.sprite = EstadoDoJogo.Instance.MidiasSelecionadas[3].sprite;
    }

    private IEnumerator UpdateBarCoroutine(float score)
    {
        float initialValue = classQualityBar.value;

        for (float i = 0; i <= animationTime; i += Time.deltaTime)
        {
            classQualityBar.value = initialValue + ((score - initialValue) / animationTime) * i;
            yield return null;
        }

        classQualityBar.value = score;  // Corretivo final para evitar erros de imprecisão

        yield return null;
    }
}
