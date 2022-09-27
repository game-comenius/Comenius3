using UnityEngine;

public class ClassDurationBar : BarControl
{
    [SerializeField] private int totalClassSteps;

    public override void UpdateBar()
    { 
        
        progress += 1.0f / totalClassSteps;

        StartCoroutine(UpdatePercentageTextCoroutine(slider.value));
        StartCoroutine(UpdateBarCoroutine());
    }
}
