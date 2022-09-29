using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocadorDeCena : MonoBehaviour
{
    // Este campo será definido através do Inspector de acordo com as regras
    // definidas no CustomEditor TrocadorDeCenaEditor.cs para esta classe
    [HideInInspector] public int IndiceDaCenaAlvo;

    public void TrocarCena()
    {
        try
        {
            if(SceneManager.GetActiveScene().name == "Sala de Aula ABProj 1-2" || SceneManager.GetActiveScene().name == "CidadeFuncional")
            {
                Invoke("CarregarCenaDelay", 1);
            }
            else
            {
                SceneManager.LoadScene(IndiceDaCenaAlvo);
            }
         
        }
        catch (System.Exception)
        {
            Debug.LogWarning("É preciso definir uma cena através do Inspector antes de chamar o método TrocarCena()!");
        }
    }

    public void CarregarCena(string sceneName)
    {
        try
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        }
        catch(System.Exception e) {
            Debug.LogWarning(e);
        }
    }

    private void CarregarCenaDelay()
    {
        SceneManager.LoadScene(IndiceDaCenaAlvo);
    }
}
