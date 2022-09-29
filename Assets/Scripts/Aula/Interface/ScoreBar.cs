using System.Diagnostics;
using UnityEngine.SceneManagement;
public class ScoreBar : BarControl
{
    // Sobrecarga do UpdateBar
    public void UpdateBar(int scoreDiff)
    {
        if(SceneManager.GetActiveScene().name == "CidadeFuncional" && !EstadoDoJogo.Instance.pVez)
        {
            progress = ((float)scoreDiff / 100) + EstadoDoJogo.Instance.score / 100;
            EstadoDoJogo.Instance.AtualizarScore((float)scoreDiff);
            EstadoDoJogo.Instance.pVez = true;
        }
        else if(SceneManager.GetActiveScene().name == "CidadeFuncional")
        {
            EstadoDoJogo.Instance.AtualizarScore((float)scoreDiff);
            progress = (EstadoDoJogo.Instance.score / 100) ;
           
        }
        else
        {
            progress += (float)scoreDiff / 100.0f;
        }
   
        StartCoroutine(UpdatePercentageTextCoroutine(slider.value));
        StartCoroutine(UpdateBarCoroutine());
    }
 
}
