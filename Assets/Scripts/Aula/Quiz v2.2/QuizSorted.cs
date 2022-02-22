using System.Collections.Generic;
using UnityEngine;

public class QuizSorted : QuizBase
{
    [SerializeReference] private List<AffirmationSorted> affirmations;
    [SerializeField] private List<string> sortedAnswers;

    public void NotifyDrag(AffirmationSorted affirmation, bool up)
    {

    }

    protected override void BuildQuiz()
    {

    }

    protected override void Evaluate()
    {

    }
}
