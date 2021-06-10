﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Slider))]
public class BarraTaxaDeAcertoNosQuizzes2 : MonoBehaviour
{
    [SerializeField] [Range(0, 1)] float velocidadeDaBarra = 1;
    [SerializeField] TextMeshProUGUI textoTaxaDeAcertoNosQuizzes;

    [SerializeField] Slider slider;

    // Valor da barra é de 0 a 1
    private float valor;
    public float Valor
    {
        get => valor;
        set
        {
            valor = value;
            slider.value = value;
            // Mostrar taxa de acerto nos quizzes como porcentagem no texto e arredondada para cima
            textoTaxaDeAcertoNosQuizzes.text = $"{Mathf.Ceil(value * 100)}%";
        }
    }

    private void Awake()
    {
        slider = transform.GetComponent<Slider>();

    }

    // Barra começa vazia
    void Start()
    {
        this.Valor = 0;
    }

    public void PreencherBarra(float quantidade)
    {
        StartCoroutine(PreencherBarraAnimation(quantidade));
    }

    private IEnumerator PreencherBarraAnimation(float quantidade)
    {
        // Animar preenchimento da barra
        var tempoParaPreencher = 1 / velocidadeDaBarra;
        var objetivo = this.Valor + quantidade;
        if (objetivo > 1) objetivo = 1;

        while (this.Valor < objetivo)
        {
            yield return null;
            this.Valor += (quantidade / tempoParaPreencher) * Time.deltaTime;
        }
        if (this.Valor > objetivo) this.Valor = objetivo;
    }
}
