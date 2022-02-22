using System.Collections.Generic;
using UnityEngine;

public class QuizMultipleChoice : QuizBase
{
    [SerializeReference] private List<AffirmationMultipleChoice> affirmations;
    [SerializeField] private List<string> correctAnswers;
    [SerializeField] private List<string> wrongAnswers;

    private int selectedAffirmationIndex;

    public void NotifySelection(AffirmationMultipleChoice affirmation)
    {
        if (selectedAffirmationIndex >= 0)
            affirmations[selectedAffirmationIndex].Selection();

        selectedAffirmationIndex = affirmations.IndexOf(affirmation);
    }

    protected override void BuildQuiz()
    {
        selectedAffirmationIndex = -1;
        int correctAnswerIndex = Random.Range(0, maxAffirmations);

        for (int i = 0; i < maxAffirmations; i++)
        {
            if (i == correctAnswerIndex)
            {
                affirmations[i].text.text = correctAnswers[Random.Range(0, correctAnswers.Count)];
            }
            else
            {
                affirmations[i].text.text = wrongAnswers[Random.Range(0, correctAnswers.Count)];
                wrongAnswers.Remove(affirmations[i].text.text);
            }
        }
    }

    protected override void Evaluate()
    {
        correctAnswersRatio = 0.0f;

        for (int i = 0; i < maxAffirmations; i++)
        {
            if (affirmations[i].correct)
                affirmations[i].UpdateResultColor(true);
            else
                affirmations[i].UpdateResultColor(false);

            if (affirmations[i].selected && affirmations[i].correct)
                correctAnswersRatio = 1.0f;
        }
    }
}
