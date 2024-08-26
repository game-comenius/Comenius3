using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClassFeedback : MonoBehaviour
{
    [SerializeField] private StateMachineController controller;
    [SerializeField] private TextMeshProUGUI classQualityText;
    [SerializeField] private FeedbackBar classQualityBar;
    [SerializeField] private TextMeshProUGUI comboClassificationText;
    [SerializeField] private TextMeshProUGUI comboText;
    [SerializeField] [TextArea] private string[] specificFeedbacksIdeal;
    [SerializeField] [TextArea] private string[] specificFeedbacksBoa;
    [SerializeField] [TextArea] private string[] specificFeedbacksArriscada;
    [SerializeField] private Image methodologyIcon;
    [SerializeField] private Image media1Icon;
    [SerializeField] private Image media2Icon;
    [SerializeField] private Image media3Icon;
    [SerializeField] private Image media4Icon;
    [SerializeField] private Text helpText;
    [SerializeField] [TextArea] private string firstHelp;
    [SerializeField] [TextArea] private string secondHelp;

    private void Start()
    {
        helpText.text = firstHelp;

        string adjective;  // TODO: Mudar isso aqui em relação as metodologias


        if (controller.score < 33)
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.INGLES:
                    adjective = "Confused";
                    break;
                case Idiomas.PORTUGUES:
                    adjective = "Confusa";
                    break;
                case Idiomas.ESPANHOL:
                    adjective = "Confundido";
                    break;

                default:
                          adjective = "Confusa";
                    break;

            }

            classQualityBar.UpdateBar(0.33f);
        }
        else if (controller.score < 66)
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.INGLES:
                    adjective = "Common";
                    break;
                case Idiomas.PORTUGUES:
                    adjective = "Comum";
                    break;
                case Idiomas.ESPANHOL:
                    adjective = "Común";
                    break;

                default:
                    adjective = "Comum";
                    break;

            }
            classQualityBar.UpdateBar(0.66f);
        }
        else
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.INGLES:
                    adjective = "Revealing";
                    break;
                case Idiomas.PORTUGUES:
                    adjective = "Reveladora";
                    break;
                case Idiomas.ESPANHOL:
                    adjective = "Revelador";
                    break;

                default:
                    adjective = "Reveladora";
                    break;

            }
            classQualityBar.UpdateBar(1.0f);
        }
        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                classQualityText.text = $"Your class was {adjective}";
                break;
            case Idiomas.PORTUGUES:
                classQualityText.text = $"Sua Aula foi {adjective}";
                break;
            case Idiomas.ESPANHOL:
                classQualityText.text = $"Tu clase fue {adjective}";
                break;

            default:
                classQualityText.text = $"Sua Aula foi {adjective}";
                break;

        }

     

        Debug.Log(EstadoDoJogo.Instance.Midias[0].nomeMidia.CategoriasDaMidia());
        Debug.Log(EstadoDoJogo.Instance.Midias[1].nomeMidia.CategoriasDaMidia());
        Debug.Log(EstadoDoJogo.Instance.Midias[2].nomeMidia.CategoriasDaMidia());
        Debug.Log(EstadoDoJogo.Instance.Midias[3].nomeMidia.CategoriasDaMidia());
        Debug.Log(ComboChecker.EvaluateCombo());
        ComboChecker.ComboClassification comboClass = ComboChecker.EvaluateComboClassification();

        string comboClassification;

        switch (comboClass)
        {
            case ComboChecker.ComboClassification.Ideal:
                comboClassification = "<b><color=#00CC00>IDEAL</color></b>";
                break;
            case ComboChecker.ComboClassification.Boa:
                comboClassification = "<b><color=#029FCF>BOA</color></b>";
                break;
            case ComboChecker.ComboClassification.Arriscada:
                comboClassification = "<b><color=#CC0000>ARRISCADA</color></b>";
                break;
            default:
                comboClassification = "[ERRO]";
                break;
        }

        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                comboClassificationText.text = $"For the {EstadoDoJogo.Instance.Metodologia.nome}, his combination of media was {comboClassification}";
                break;
            case Idiomas.PORTUGUES:
                comboClassificationText.text = $"Para a {EstadoDoJogo.Instance.Metodologia.nome}, sua combinação de mídias foi {comboClassification}";
                break;
            case Idiomas.ESPANHOL:
                comboClassificationText.text = $"Para el {EstadoDoJogo.Instance.Metodologia.nome}, su combinación de medios fue {comboClassification}";
                break;

            default:
                comboClassificationText.text = $"Para a {EstadoDoJogo.Instance.Metodologia.nome}, sua combinação de mídias foi {comboClassification}";
                break;

        }
    

        ComboChecker.Combo combo = ComboChecker.EvaluateCombo();

        
        if (EstadoDoJogo.Instance.Metodologia.nome == Metodologia.ABP.nome)
        {
            switch (combo)
            {
                case ComboChecker.Combo.abpIdeal:
                    comboText.text = specificFeedbacksIdeal[0];
                    break;
                case ComboChecker.Combo.abpBoa1:
                    comboText.text = specificFeedbacksBoa[0];
                    break;
                case ComboChecker.Combo.abpBoa2:
                    comboText.text = specificFeedbacksBoa[1];
                    break;
                case ComboChecker.Combo.abpBoa3:
                    comboText.text = specificFeedbacksBoa[2];
                    break;
                case ComboChecker.Combo.abpArriscada1:
                    comboText.text = specificFeedbacksArriscada[0];
                    break;
                case ComboChecker.Combo.abpArriscada2:
                    comboText.text = specificFeedbacksArriscada[1];
                    break;
                case ComboChecker.Combo.abpArriscada3:
                    comboText.text = specificFeedbacksArriscada[2];
                    break;
                case ComboChecker.Combo.abpArriscada4:
                    comboText.text = specificFeedbacksArriscada[3];
                    break;
                case ComboChecker.Combo.abpArriscada5:
                    comboText.text = specificFeedbacksArriscada[4];
                    break;
                case ComboChecker.Combo.abpArriscada6:
                    comboText.text = specificFeedbacksArriscada[5];
                    break;
                case ComboChecker.Combo.abpArriscada7:
                    comboText.text = specificFeedbacksArriscada[6];
                    break;
                default:
                    comboText.text = "[Feedback não encontrado]";
                    break;
            }
        }
        else if (EstadoDoJogo.Instance.Metodologia.nome == Metodologia.SAI.nome)
        {
            switch (combo)
            {
                case ComboChecker.Combo.saiIdeal:
                    comboText.text = specificFeedbacksIdeal[0];
                    break;
                case ComboChecker.Combo.saiBoa1:
                    comboText.text = specificFeedbacksBoa[0];
                    break;
                case ComboChecker.Combo.saiBoa2:
                    comboText.text = specificFeedbacksBoa[1];
                    break;
                case ComboChecker.Combo.saiBoa3:
                    comboText.text = specificFeedbacksBoa[2];
                    break;
                case ComboChecker.Combo.saiBoa4:
                    comboText.text = specificFeedbacksBoa[3];
                    break;
                case ComboChecker.Combo.saiArriscada1:
                    comboText.text = specificFeedbacksArriscada[0];
                    break;
                case ComboChecker.Combo.saiArriscada2:
                    comboText.text = specificFeedbacksArriscada[1];
                    break;
                case ComboChecker.Combo.saiArriscada3:
                    comboText.text = specificFeedbacksArriscada[2];
                    break;
                default:
                    comboText.text = "[Feedback não encontrado]";
                    break;
            }
        }

        else if (EstadoDoJogo.Instance.Metodologia.nome == Metodologia.ABProj.nome)
        {
            Debug.Log(EstadoDoJogo.Instance.Midias[0].nomeMidia +" " + EstadoDoJogo.Instance.Midias[0].nomeMidia.CategoriasDaMidia());
            Debug.Log(EstadoDoJogo.Instance.Midias[1].nomeMidia + " " + EstadoDoJogo.Instance.Midias[1].nomeMidia.CategoriasDaMidia());
            Debug.Log(EstadoDoJogo.Instance.Midias[2].nomeMidia + " " + EstadoDoJogo.Instance.Midias[2].nomeMidia.CategoriasDaMidia());
            Debug.Log(EstadoDoJogo.Instance.Inteligencias);
            Debug.Log(EstadoDoJogo.Instance.Midias[1].nomeMidia.ToString());
          Debug.Log(combo);
            switch (combo)
            {
                case ComboChecker.Combo.abpjIdeal1:
                    comboText.text = specificFeedbacksIdeal[0];
                    break;
                case ComboChecker.Combo.abpjIdeal2:
                    comboText.text = specificFeedbacksIdeal[0];
                    break;
                case ComboChecker.Combo.abpjIdeal3:
                    comboText.text = specificFeedbacksIdeal[0];
                    break;
                case ComboChecker.Combo.abpjIdeal4:
                    comboText.text = specificFeedbacksIdeal[0];
                    break;
                case ComboChecker.Combo.abpjBoa1:
                    comboText.text = specificFeedbacksBoa[0];
                    break;

                case ComboChecker.Combo.abpjBoa2:
                    comboText.text = specificFeedbacksBoa[1];
                    break;

                case ComboChecker.Combo.abpjBoa3:
                    comboText.text = specificFeedbacksBoa[1];
                    break;

                case ComboChecker.Combo.abpjBoa4:
                    comboText.text = specificFeedbacksBoa[2];
                    break;

                case ComboChecker.Combo.abpjArriscado1:
                    comboText.text = specificFeedbacksArriscada[1];
                    break;

                case ComboChecker.Combo.abpjArriscado2:
                    comboText.text = specificFeedbacksArriscada[1];
                    break;

                case ComboChecker.Combo.abpjArriscado3:
                    comboText.text = specificFeedbacksArriscada[1];
                    break;

                case ComboChecker.Combo.abpjArriscado4:
                    comboText.text = specificFeedbacksArriscada[1];
                    break;

                case ComboChecker.Combo.abpjArriscado5:
                    comboText.text = specificFeedbacksArriscada[0];
                    break;


                default:
                    comboText.text = "[Feedback não encontrado]";
                    break;
            }
        }

        methodologyIcon.sprite = EstadoDoJogo.Instance.Metodologia.sprite;

        media1Icon.sprite = EstadoDoJogo.Instance.Midias[0].sprite;
        media2Icon.sprite = EstadoDoJogo.Instance.Midias[1].sprite;
        media3Icon.sprite = EstadoDoJogo.Instance.Midias[2].sprite;
        media4Icon.sprite = EstadoDoJogo.Instance.Midias[3].sprite;
    }

    public void UpdateHelpText()
    {
        helpText.text = secondHelp;
    }
}
