public class FeedbackBar : BarControl
{
    // Sobrecarga do UpdateBar
    public void UpdateBar(float value)
    {
        progress = value;

        StartCoroutine(UpdateBarCoroutine());
    }
}
