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
    METODOLOGIA,
    METODOLOGIA2,
    METODOLOGIA3,
    SALA_DE_AULA_INVERTIDA,
    TEXT_METODOLOGIA,
    LABORATORIO,
    CONHECA_AS_METODOLOGIAS,
    TEXT_METODOLOGIA2,
    TEXT_METODOLOGIA3,
    QUARTO_DO_ALUNO,
    SALA_DE_AULAB,
    APRENDIZAGEM_BASEADA_EM_PROJETOS,
    CIDADE,
    AGORA_E_COM_VOCE,
    SELECIONE_UMA_DAS_OPCOES,
    OU_METODOLOGIAS_ATIVAS,
    POP_INTRO_2,
    PERSONAGEM,
    ESCOLHA_AVATAR,
    ESTE_AVATAR,
    MENU_PRINCIPAL,
    VOLTAR_MENU,
    SOBRE_O_JOGO,
    INFORMACOES,
    SOBRE_O_COMMENIUS_3,
    AVALIAR_JOGO,
    PRODUCAO_COORDENACAO,
    GAME_DESIGN,
    ARTE_UI,
    ARTE_DA_CIDADE,
    PROGRAMACAO,
    PEDAGOGICO,
    UX_GESTAO,
    ESCOLHA_ESTAGIO_APRENDIZAGEM,
    CNPG,
    COM_BASE_ENSINO,
    QUAL_PERFIL,
    NIVEL_DE_ENSINO,
    CAMPOS_DE_EXPERIENCIA,
    INTELIGENCIAS_MULTIPLAS,
    CARACTERISTICAS_DA_TURMA,
    PERFIL_ESTUDANTES_TURMA,
    SAO_AS_CARACTERISTICAS,
    CLIQUE_EM_CONTINUAR,
    CLIQUE_EM_CONFIRMAR,
    DICA_SEUS_ESTUDANTES,
    OLA_SOU_LURDINHA,
    AGORA_VOCE,
    QUAL_SERA_O_TEMA,
    CRIEI_UM_TEMA,
    ESSA_ESCOLHA,
    NO_MAXIMO_45,
    NA_APRENDIZAGEM_BASEADA,
    APRENSENTAR_O_PROBLEMA,
    SEQUENCIA_DIDATICA,
    PRIMEIRO_MOMENTO,
    SEGUNDO_MOMENTO,
    QUARTO_APRESENTAR,
    ESPACO_DE_APRENDIZAGEM,
    SUA_AULA_ACONTECERA,
    DURANTE_O_MOMENTO,
    VOCE_IRA_JOGAR_UMA_AULA,
    NA_SEQUENCIA_DA_APRENDIZAGEM,
    APRESENTAR_O_PROBLEMA,
    APRESENTAR_AS_RESPOSTAS,
    ESCOLHA_AS_MIDIAS,
    MIDIAS_PRIMEIRO_MOMENTO,
    ESCOLHA_DUAS_MIDIAS,
    POPULAR,
    PRODUCAO,
    CONSULTA,
    EXPOSICAO,
    DIGITAL,
    TRADICIONAL,
    AUDIO_VISUAL,
    CONFIRA_SE_SUA_ESCOLHA,
    AREA_DE_CONHECIMENTO,
    FICHA_DOIS,
    SUA_AULA,
    REVISE_AS_CARACTERISTICAS,
    NASA_SALA_INVERTIDA,
    CONFIRMAR,
    SEQUENCIA_DICATICA2,
    NA_SALA_DE_AULA_INVERTIDA_DOCENTE,
    MIDIAS_QUARTO,
    NA_SEQUENCIA,
    MIDIAS_SALA,
    SALA_DE_AULA,
    CONHECER_SALA_INVERTIDA,
    QUARTO_ESTUDANTE,
    NO_MOMENTO,
    NO_MOMENTO_DO_QUARTO,
    FICHA_2_RESUMO_2,
    LOGO_APOS,
    QUAL_SERA_O_SEU,
    DESEJA_REALMENTE,
    SIM,
    NAO,
    O_PROBLEMA_DO_PROJETO,
    POR_MEIO,
    A_SEQUENCIA_DIDATICA,
    NO_MOMENTO_DA_CIDADE,
    NO_MOMENTO_AULA,
    NA_SEQUENCIA_PROJETOS,
    DEFINIR_ESCOPO,
    APRESENTAR_RESULTADOS,
    TERCEIRO_MOMENTO,
    EXERCUTAR_ACOES,
    VAMOS_PARA_TERCEIRA,
    RELEMBRAR_CARACTERISTICAS,
    SEMPRE_QUE_POSSIVEL,
    DICA,
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
