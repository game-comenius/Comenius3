﻿using UnityEngine;
using UnityEngine.UI;

public abstract class FormatoDeQuiz : MonoBehaviour
{
    [SerializeField] Text enunciado;

    public string TextoDoEnunciado
    {
        get { return enunciado.text; }
        set { enunciado.text = value; }
    }

    public virtual float TaxaDeAcerto { get; protected set; }

    public Button BotaoConfirmar;

    public bool RespostaConfirmada { get; set; }

    protected virtual void Start()
    {
        Esconder();

        // Definir funcionalidade do botão confirmar
        BotaoConfirmar.onClick.AddListener(() =>
        {
            // Impedir que o jogador confirme mais de uma vez a resposta dele
            BotaoConfirmar.gameObject.SetActive(false);
            ConfirmarResposta();
        });
    }

    protected abstract void ConfirmarResposta();

    public virtual void Esconder()
    {
        gameObject.SetActive(false);
    }

    public virtual void Mostrar()
    {
        gameObject.SetActive(true);
    }
}