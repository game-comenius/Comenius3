﻿using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "MomentoInteracao", menuName = "Comenius3/MomentoInteracao", order = 0)]
public class MomentoInteracao : ScriptableObject
{
    public List<NomeDeMidia> midias;
    public PaginaInteracao[] paginas;
    public PaginaInteracao[] paginasPtbr;
    public PaginaInteracao[] paginasEua;
    public PaginaInteracao[] paginasEsp;
    public CelulaReference opcoesDeEscolha;
    public CelulaReference opcoesDeEscolhaPtbr;
    public CelulaReference opcoesDeEscolhaEua;
    public CelulaReference opcoesDeEscolhaEsp;
    public int paginaDoDropdown = -1;
    public bool alunoFeliz;
    public string reacaoPositiva;
    public string reacaoPositivaPtbr;
    public string reacaoPositivaEua;
    public string reacaoPositivaEsp;
    public string reacaoNegativa;
    public string reacaoNegativaPtbr;
    public string reacaoNegativaEua;
    public string reacaoNegativaEsp;

    [Header("Usado apenas na ABProj")]
    public LocationChecker.Location lugar;

    public static List<MomentoInteracao> momentos { get; private set; }

    public static MomentoInteracao GetMomentFromArchives()
    {
        if (momentos == null)
        {
            momentos = new List<MomentoInteracao>(Resources.LoadAll<MomentoInteracao>("MomentosInteracao/GeradosPelaPlanilha"));
            if (momentos == null)
                Debug.LogError("Gere os momentos de novo no menu Ferramentas/GerarMomentosDaPlanilha");
        }

        // Pega um momento gerado pela da planilha
        return momentos[Random.Range(0, momentos.Count)];
    }

    public static MomentoInteracao GetMomentFromArchives(NomeDeMidia midia)
    {
        if (momentos == null)
        {
            momentos = new List<MomentoInteracao>(Resources.LoadAll<MomentoInteracao>("MomentosInteracao/GeradosPelaPlanilha"));
            if (momentos == null)
                Debug.LogError("Gere os momentos denovo no menu Ferramentas/GerarMomentosDaPlanilha");
        }

        foreach (MomentoInteracao momento in momentos)
        {
            foreach (NomeDeMidia _midia in momento.midias)
            {
                if (_midia == midia)
                    return momento;
            }
        }
        return GetMomentFromArchives();
    }
}

[System.Serializable]
public class PaginaInteracao
{
    [HideInInspector]
    public string titulo
    {
        get
        {
            if (professorFalando)
            {
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        return "Teacher";
                    case Idiomas.PORTUGUES:
                        return "Professor";
                    case Idiomas.ESPANHOL:
                        return "Maestro";
                  
                }
                return "Prof";
            }
          
            else
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        return "Student";
                    case Idiomas.PORTUGUES:
                        return "Estudante";
                    case Idiomas.ESPANHOL:
                        return "Alumno";

                }
            return "Estudante";
        }
    }

    public CelulaReference texto;

    public bool professorFalando;  // Se for falso o aluno esta falando
}