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
            SceneManager.LoadScene(IndiceDaCenaAlvo);
        }
        catch (System.Exception)
        {
            Debug.LogWarning("É preciso definir uma cena através do Inspector antes de chamar o método TrocarCena()!");
        }
    }
}
