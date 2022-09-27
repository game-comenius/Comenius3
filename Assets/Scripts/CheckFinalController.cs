using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static ComboChecker;

public class CheckFinalController : MonoBehaviour
{
    public Image aluno;
    public Sprite[] alunoFeliz;
    public Sprite[] alunoTriste;
    private ComboChecker.ComboClassification comboClass;

    void Start()
    {
        //
        comboClass = ComboChecker.EvaluateComboClassification();
    }
    
    public void MostrarFeedbackAluno()
    {
        switch (comboClass)
        {
            case ComboChecker.ComboClassification.Ideal:
                
                break;
            case ComboChecker.ComboClassification.Boa:

                break;
            case ComboChecker.ComboClassification.Arriscada:

                break;
            default:

                break;
        }
    }

    public void SwitchMidias()
    {
        

    }
}
