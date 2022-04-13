public class ScoreBar : BarControl
{
    // Sobrecarga do UpdateBar
    public void UpdateBar(int scoreDiff)
    {
        progress += (float)scoreDiff / 100.0f;

        StartCoroutine(UpdatePercentageTextCoroutine(slider.value));
        StartCoroutine(UpdateBarCoroutine());
    }
}
