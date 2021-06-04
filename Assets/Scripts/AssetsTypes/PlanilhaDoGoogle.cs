using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEditor;

[CreateAssetMenu(menuName = "Comenius3/PlanilhaGoogle")]
[System.Serializable]
public class PlanilhaDoGoogle : ScriptableObject
{
    public string[] data;
    public string sheetID;//Id publico da planilha pegar https://docs.google.com/spreadsheets/d/YOUR_SHEET_ID/...
    public string pageID;//ID da pagina numero que aparece dps de gid=, 0 se for a primeira pagina
    public int quantidadeDeLinhas;
    public int quantidadeDeColunas;

    private string url;
    private UnityWebRequest _webRequest;

    private void OnEnable()
    {
        url = "https://docs.google.com/spreadsheets/d/" + sheetID + "/export?format=csv&gid=" + pageID;
    }

    public string GetDataAt(int row, int column)
    {
        if (data == null)
        {
            Debug.LogError("Planilha sem dados");
            return null;
        }
        if (row >= quantidadeDeLinhas || row < 0 || column >= quantidadeDeColunas || column < 0)
            return null;

        return data[row * quantidadeDeColunas + column]; ;
    }

    //Faz o web request e adiciona a faz a funcao check escutar se o request acabou
    public void MakeRequest()
    {
        _webRequest = UnityWebRequest.Get(url);
        _webRequest.SendWebRequest();

        EditorApplication.update += CheckForImportRequestEnd; 
    }

    //Monitora o request e chama as funcoes de processamento dos dados
    private void CheckForImportRequestEnd()
    {
        if (_webRequest != null && _webRequest.isDone)
        {
            if (_webRequest.isNetworkError || _webRequest.isHttpError)
            {
                Debug.Log(_webRequest.error);
                return;
            }


            var contentData = _webRequest.downloadHandler.text;


            data = ParseData(contentData);

            EditorApplication.update -= CheckForImportRequestEnd;
            Debug.Log("Dados atualizados!");
        }
    }

    //Funcao de processamento dos dados
    private string[] ParseData(string contentData)
    {
        //Divide o CSV por linhas
        string[] linhas = CSVHelper.SplitExludeQuotes(contentData, '\n');

        //Calcula quantidade de linhas e colunas
        quantidadeDeLinhas = linhas.Length;

        quantidadeDeColunas = linhas[0].Split(',').Length;
        ////Loop para achar a quantidade correta de colunas, achando a linha com a maior quantidade de colunas
        foreach (string linha in linhas)
        {
            int colunasNaLinha = linha.Split(',').Length;
            if (colunasNaLinha > quantidadeDeColunas)
                quantidadeDeColunas = colunasNaLinha;
        }

        //Divide as linhas nas celulas
        List<string> data = new List<string>();

        for (int linha = 0; linha < quantidadeDeLinhas; linha++)
        {
            string[] celulasDaLinha = linhas[linha].Split(',');
            data.AddRange(celulasDaLinha);
        }

        return data.ToArray();
    }

    
}
public static class CSVHelper

    //Funcao especial para nas considerar as quebras de linha dentro das celulas do csv
{
    public static string[] SplitExludeQuotes(string aText, char aSplitChar)
    {
        string[] pieces = aText.Split(aSplitChar);
        bool repairing = false;

        char c = '"';

        List<string> result = new List<string>();

        foreach (string piece in pieces)
        {
            if (repairing)
            {
                string last = result[result.Count - 1];
                

                last = last + "\n" + piece;
                
                //Remove o caracter " (aspas duplas)
                string newLast = "";
                foreach (char charI in last.ToCharArray())
                {
                    if (charI != c)
                        newLast += charI;
                }
                last = newLast;

                result[result.Count - 1] = last;
            }
            else
            {
                result.Add(piece);
            }
            if (piece.Contains(c.ToString()))//Se contem " comeca/para de reparar
            {
                repairing = !repairing;
            }
        }
        return result.ToArray();
    }


} 