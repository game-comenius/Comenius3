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
                type1 = "";
                if (mediasFlags[i].HasFlag(CategoriasDeMidia.Popular))
                {

                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type1 = "Popular";
                            break;
                        case Idiomas.PORTUGUES:
                            type1 = "Popular";
                            break;
                        case Idiomas.ESPANHOL:
                            type1 = "Popular";
                            break;
                        default:
                            type1 = "Popular";
                            break;
                    }
                }
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.ProducaoArmazenamento))
                {
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type1 = "Production";
                            break;
                        case Idiomas.PORTUGUES:
                            type1 = "Popular";
                            break;
                        case Idiomas.ESPANHOL:
                            type1 = "Producción";
                            break;
                        default:
                            type1 = "Popular";
                            break;
                    }
                }
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.ConsultaRepositorio))
                {
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type1= "Query";
                            break;
                        case Idiomas.PORTUGUES:
                            type1 = "Consulta";
                            break;
                        case Idiomas.ESPANHOL:
                            type1 = "Exhibición";
                            break;
                        default:
                            type1 = "Consulta";
                            break;
                    }
                }
                else
                {
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type2 = "Exhibition";
                            break;
                        case Idiomas.PORTUGUES:
                            type2 = "Exposição";
                            break;
                        case Idiomas.ESPANHOL:
                            type2 = "Exhibición";
                            break;
                        default:
                            type2 = "Exposição";
                            break;
                    }
                }

                if (mediasFlags[i].HasFlag(CategoriasDeMidia.Digital))
                {

                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type2 = "Digital";
                            break;
                        case Idiomas.PORTUGUES:
                            type2 = "Digital";
                            break;
                        case Idiomas.ESPANHOL:
                            type2 = "Digital";
                            break;
                        default:
                            type2 = "Digital";
                            break;
                    }
                }
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.Impressa))
                {
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type2 = "Traditional";
                            break;
                        case Idiomas.PORTUGUES:
                            type2 = "Tradicional";
                            break;
                        case Idiomas.ESPANHOL:
                            type2 = "Tradicional";
                            break;
                        default:
                            type2 = "Tradicional";
                            break;
                    }
                }
                else
                {
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type2 = "Audio-visual";
                            break;
                        case Idiomas.PORTUGUES:
                            type2 = "Audiovisual";
                            break;
                        case Idiomas.ESPANHOL:
                            type2 = "Audiovisual";
                            break;
                        default:
                            type2 = "Audiovisual";
                            break;
                    }
                }

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
                type1 = "";
                if (mediasFlags[i].HasFlag(CategoriasDeMidia.Popular))
                {

                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type1 = "Popular";
                            break;
                        case Idiomas.PORTUGUES:
                            type1 = "Popular";
                            break;
                        case Idiomas.ESPANHOL:
                            type1 = "Popular";
                            break;
                        default:
                            type1 = "Popular";
                            break;
                    }
                }
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.ProducaoArmazenamento))
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type1 = "Production";
                            break;
                        case Idiomas.PORTUGUES:
                            type1 = "Popular";
                            break;
                        case Idiomas.ESPANHOL:
                            type1 = "Producción";
                            break;
                        default:
                            type1 = "Popular";
                            break;
                    }
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.ConsultaRepositorio))
                {
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type1 = "Query";
                            break;
                        case Idiomas.PORTUGUES:
                            type1 = "Consulta";
                            break;
                        case Idiomas.ESPANHOL:
                            type1 = "Exhibición";
                            break;
                        default:
                            type1 = "Consulta";
                            break;
                    }
                }

                else
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type2 = "Exhibition";
                            break;
                        case Idiomas.PORTUGUES:
                            type2 = "Exposição";
                            break;
                        case Idiomas.ESPANHOL:
                            type2 = "Exhibición";
                            break;
                        default:
                            type2 = "Exposição";
                            break;
                    }

                if (mediasFlags[i].HasFlag(CategoriasDeMidia.Digital))
                {
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type2 = "Digital";
                            break;
                        case Idiomas.PORTUGUES:
                            type2 = "Digital";
                            break;
                        case Idiomas.ESPANHOL:
                            type2 = "Digital";
                            break;
                        default:
                            type2 = "Digital";
                            break;
                    }
                }
                else if (mediasFlags[i].HasFlag(CategoriasDeMidia.Impressa))
                {
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type2 = "Traditional";
                            break;
                        case Idiomas.PORTUGUES:
                            type2 = "Tradicional";
                            break;
                        case Idiomas.ESPANHOL:
                            type2 = "Tradicional";
                            break;
                        default:
                            type2 = "Tradicional";
                            break;
                    }
                }
      
                else
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            type2 = "Audio-visual";
                            break;
                        case Idiomas.PORTUGUES:
                            type2 = "Audiovisual";
                            break;
                        case Idiomas.ESPANHOL:
                            type2 = "Audiovisual";
                            break;
                        default:
                            type2 = "Audiovisual";
                            break;
                    }

                if (i == 0)
                    media1TypesText.text = $"{type1}\n{type2}";
                else
                    media2TypesText.text = $"{type1}\n{type2}";
            }

        }
    }
}
