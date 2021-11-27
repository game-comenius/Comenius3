using UnityEngine;

public class AnimacaoRolagem : MonoBehaviour
{
    [SerializeField] private GameObject[] itens;

    private float velocidade = Screen.height / 10f;
    private Vector2[] posicoesOriginais;
    private int indiceExibicao;

    private void Start()
    {
        indiceExibicao = 0;
        posicoesOriginais = new Vector2[itens.Length];

        for (int i = 0; i < itens.Length; ++i)
        {
            posicoesOriginais[i] = itens[i].GetComponent<RectTransform>().anchoredPosition;
        }
    }

    void Update()
    {
        itens[indiceExibicao].transform.Translate(Vector3.up * Time.deltaTime * velocidade);

        RectTransform rect = itens[indiceExibicao].GetComponent<RectTransform>();


        if (rect.anchoredPosition.y > Screen.height)
        {
            rect.anchoredPosition = posicoesOriginais[indiceExibicao];

            ++indiceExibicao;
            if (indiceExibicao == itens.Length)
            {
                indiceExibicao = 0;
            }
        }
    }
}
