using System.Diagnostics;
using UnityEngine.SceneManagement;
public class ScoreBar : BarControl
{
    // Sobrecarga do UpdateBar
    public void UpdateBar(int scoreDiff)
    {
        if(SceneManager.GetActiveScene().name == "CidadeFuncional")
        {
            progress = ((float)scoreDiff + EstadoDoJogo.Instance.score) / 100.0f;
            EstadoDoJogo.Instance.AtualizarScore(progress);
        }
        else
        {
            progress += (float)scoreDiff / 100.0f;
        }
   
        StartCoroutine(UpdatePercentageTextCoroutine(slider.value));
        StartCoroutine(UpdateBarCoroutine());
    }
 
}
