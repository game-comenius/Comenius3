using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITextsHelper : MonoBehaviour
{
    [SerializeField] private ChaveTextos chave;
    [SerializeField] private bool caixaAlta;

    private Text text;
    private TextMeshProUGUI tmp;

	private void OnEnable()
	{
		AtualizarTexto();
	}

	public void AtualizarTexto()
	{
		if (GetComponent<Text>() != null) text = GetComponent<Text>(); //se for objeto com Text normal, preenche a variavel
		else if (GetComponent<TextMeshProUGUI>() != null) tmp = GetComponent<TextMeshProUGUI>(); //se for objeto com TextMeshPro, preenche a variavel

		string texto = Textos.GetInstance().ObterTexto(chave); //pega o texto de acordo com a chave definida
		if (caixaAlta) texto.ToUpper(); //transforma o texto em caixa alta se marcado

		//verificar qual das duas variaveis de texto esta sendo preenchida e coloca o texto definido pela chave no objeto
		if (text != null) text.text = texto;
		else if (tmp != null) tmp.text = texto;
	}
}
