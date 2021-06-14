using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class GeradorDeMomentosDaPlanilha
{

    private static string planilhaPath = "Assets/Resources/PlanilhasGoogle/PlanilhaMomentosDeInteracao.asset";
    
    private static string momentosParentFolderPath = "Assets/Resources/MomentosInteracao";
    private static string momentosFoldername = "GeradosPelaPlanilha";

    private static List<MomentoInteracao> momentos;
    [MenuItem("Ferramentas/GerarMomentosDaPlanilha")]
    public static void GerarMomentos()
    {
        //Gera uma nova lista de momentos
        momentos = new List<MomentoInteracao>();

        //Carrega a planilha baseado no endereço fornecido
        PlanilhaDoGoogle planilha = AssetDatabase.LoadAssetAtPath<PlanilhaDoGoogle>(planilhaPath);

        //Gera os momentos e salva eles
        for (int linha = 2; linha < planilha.quantidadeDeLinhas; linha++)
        {
            MomentoInteracao momento = ScriptableObject.CreateInstance<MomentoInteracao>();

            //Configura a pagina do aluno
            PaginaInteracao paginaDoAluno = new PaginaInteracao();
            paginaDoAluno.professorFalando = false;
            paginaDoAluno.texto = new CelulaReference(planilha, linha, 0);

            //Configura a pagina do professor
            PaginaInteracao paginaProfessor = new PaginaInteracao();
            paginaProfessor.professorFalando = true;
            paginaProfessor.texto = new CelulaReference(planilha, linha, 1);
          
            //Adiciona as paginas configuradas
            momento.paginas = new PaginaInteracao[] { paginaDoAluno, paginaProfessor };

            //Configura selecao
            momento.opcoesDeEscolha = new CelulaReference(planilha, linha, 2);

            //Salva o momento na lista
            momentos.Add(momento);

        }
        //Salva o momento na pasta
        AssetDatabase.DeleteAsset(momentosParentFolderPath +"/"+ momentosFoldername);
        AssetDatabase.CreateFolder(momentosParentFolderPath, momentosFoldername);
        int index = 0;
        foreach (MomentoInteracao momento in momentos)
        {
            AssetDatabase.CreateAsset(momento, momentosParentFolderPath + "/" + momentosFoldername + "/MomentoPlanilha " + index + ".asset");
            index++;
        }
        AssetDatabase.SaveAssets();
    }
}
