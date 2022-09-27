using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DidaticSequencePopup : MonoBehaviour
{
    [SerializeField] private Image media1Icon;
    [SerializeField] private Image media2Icon;
    [SerializeField] private Image media3Icon;

    public Image img1;
    public Image img2;
    public Image img3;
    [SerializeField] private TextMeshProUGUI media1TypesText;
    [SerializeField] private TextMeshProUGUI media2TypesText;
    [SerializeField] private TextMeshProUGUI media3TypesText;
    [SerializeField] private bool firstStageSelection;

    private void OnEnable()
    {
        if(SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {
            int startingIndex = firstStageSelection ? 0 : 2;

        
            CategoriasDeMidia[] mediasFlags = new CategoriasDeMidia[3];

            mediasFlags[0] = EstadoDoJogo.Instance.Midias[0].nomeMidia.CategoriasDaMidia();
            mediasFlags[1] = EstadoDoJogo.Instance.Midias[1].nomeMidia.CategoriasDaMidia();
            mediasFlags[2] = EstadoDoJogo.Instance.Midias[2].nomeMidia.CategoriasDaMidia();
  
            media1Icon.sprite = EstadoDoJogo.Instance.Midias[0].sprite;

            media2Icon.sprite = EstadoDoJogo.Instance.Midias[1].sprite;

            media3Icon.sprite = EstadoDoJogo.Instance.Midias[2].sprite;


            string type1;
            string type2;

            for (int i = 0; i < 3; i++)
            {
                if (mediasFlags[i].HasFlag(CategoriasDeMidia.Popular))
                    type1 = "Popular";
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.ProducaoArmazenamento))
                    type1 = "Produção";
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.ConsultaRepositorio))
                    type1 = "Consulta";
                else
                    type1 = "Exposição";

                if (mediasFlags[i].HasFlag(CategoriasDeMidia.Digital))
                    type2 = "Digital";
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.Impressa))
                    type2 = "Tradicional";
                else
                    type2 = "Audiovisual";

                if (i == 0)
                    media1TypesText.text = $"{type1}\n{type2}";
                else if( i == 1)
                    media2TypesText.text = $"{type1}\n{type2}";
                else
                {
                    media3TypesText.text = $"{type1}\n{type2}";
                }
            }
        }
        else
        {
            int startingIndex = firstStageSelection ? 0 : 2;

            media1Icon.sprite = EstadoDoJogo.Instance.Midias[startingIndex].sprite;
            media2Icon.sprite = EstadoDoJogo.Instance.Midias[startingIndex + 1].sprite;

            CategoriasDeMidia[] mediasFlags = new CategoriasDeMidia[2];

            mediasFlags[0] = EstadoDoJogo.Instance.Midias[startingIndex].nomeMidia.CategoriasDaMidia();
            mediasFlags[1] = EstadoDoJogo.Instance.Midias[startingIndex + 1].nomeMidia.CategoriasDaMidia();

            string type1;
            string type2;

            for (int i = 0; i < 2; i++)
            {
                if (mediasFlags[i].HasFlag(CategoriasDeMidia.Popular))
                    type1 = "Popular";
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.ProducaoArmazenamento))
                    type1 = "Produção";
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.ConsultaRepositorio))
                    type1 = "Consulta";
                else
                    type1 = "Exposição";

                if (mediasFlags[i].HasFlag(CategoriasDeMidia.Digital))
                    type2 = "Digital";
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.Impressa))
                    type2 = "Tradicional";
                else
                    type2 = "Audiovisual";

                if (i == 0)
                    media1TypesText.text = $"{type1}\n{type2}";
                else
                    media2TypesText.text = $"{type1}\n{type2}";
            }

        }
    }
}
