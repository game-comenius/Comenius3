using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Idiomas
{
    _chaveInicial,

    INGLES,
    PORTUGUES,
    ESPANHOL,

    _chaveFinal
}

public enum ChaveTextos
{
    _chaveInicial,

    PRESSIONE_QUALQUER_BOTAO,
    TEXTO,
    JOGAR,
    SOBREOJOGO,
    INTRO_METODOLOGIAS_TXT,
    METODOLOGIAS_ATIVAS,
    APRENDIZAGEM_BASEADA_EM_PROBLEMAS,
    _chaveFinal
}

public class Textos
{
    private static Idiomas idiomaSelecionado;
    protected static Textos instance;
    protected string[] textos;

    public static Idiomas GetIdiomaSelecionado()
    {
        if (PlayerPrefs.HasKey("Idioma")) idiomaSelecionado = (Idiomas)PlayerPrefs.GetInt("Idioma");
        else if (instance == null)
        {
            if (Application.systemLanguage == SystemLanguage.Portuguese) idiomaSelecionado = Idiomas.PORTUGUES;
            else if (Application.systemLanguage == SystemLanguage.Spanish) TrocarIdioma(Idiomas.ESPANHOL);
            else idiomaSelecionado = Idiomas.INGLES;
        }

        return idiomaSelecionado;
    }

    public static Textos GetInstance()
    {
        if (instance == null && PlayerPrefs.HasKey("Idioma")) TrocarIdioma((Idiomas)PlayerPrefs.GetInt("Idioma"));
        else if (instance == null)
        {
            if (Application.systemLanguage == SystemLanguage.Portuguese) TrocarIdioma(Idiomas.PORTUGUES);
            else if (Application.systemLanguage == SystemLanguage.Spanish) TrocarIdioma(Idiomas.ESPANHOL);
            else TrocarIdioma(Idiomas.INGLES);
        }

        return instance;
    }

    public static void TrocarIdioma(Idiomas idioma)
    {
        idiomaSelecionado = idioma;

        switch (idioma)
        {
            case Idiomas.INGLES:
                instance = new TextosIngles();
                PlayerPrefs.SetInt("Idioma", (int)idioma);
                break;

            case Idiomas.PORTUGUES:
                instance = new TextosPortugues();
                PlayerPrefs.SetInt("Idioma", (int)idioma);
                break;

            case Idiomas.ESPANHOL:
                instance = new TextosEspanhol();
                PlayerPrefs.SetInt("Idioma", (int)idioma);
                break;
        }

        AtualizarUITexts();
    }

    protected static void AtualizarUITexts()
    {
        UITextsHelper[] th = GameObject.FindObjectsOfType<UITextsHelper>();

        foreach (UITextsHelper item in th)
        {
            item.AtualizarTexto();
        }
    }

    protected virtual void PreencherTextos()
    {
        textos = new string[(int)ChaveTextos._chaveFinal];

        for (int i = 0; i < (int)ChaveTextos._chaveFinal; i++)
        {
            textos[i] = "n/a";
        }

        AtualizarUITexts();
    }

    public string ObterTexto(ChaveTextos chave)
    {
        string retorno = "n/a";

        if ((int)chave < textos.Length)
        {
            if (textos[(int)chave] != null) return textos[(int)chave];
        }

        return retorno;
    }
}
