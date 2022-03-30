using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ControladorDeDisplayQuarto : MonoBehaviour
{
    [SerializeField] private GameObject infantil;
    [SerializeField] private GameObject fundamental;
    [SerializeField] private GameObject medio;
    [SerializeField] private GameObject superior;

    void Start()
    {
        infantil.SetActive(false);
        fundamental.SetActive(false);
        medio.SetActive(false);
        superior.SetActive(false);

        int indiceNivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsino.valor; // Verifica o nivel de ensino selecionado

        // Ativa o gameObject correspondente ao selecionado
        switch (indiceNivelDeEnsino)
        {
            case 0:  // Educacao infantil
                infantil.SetActive(true);
                break;
            case 1:  // Ensino Fundamental
                fundamental.SetActive(true);
                break;
            case 2:  // Ensino Medio
                medio.SetActive(true);
                break;
            default:  // Ensino Superior
                superior.SetActive(true);
                break;
        }

    }
}
