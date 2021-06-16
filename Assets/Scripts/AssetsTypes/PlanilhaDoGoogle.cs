using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEditor;
using UnityEngine.Events;

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

    public string Url
    {
        get
        {
            if (pageID == null)
                pageID = "0";
            url = "https://docs.google.com/spreadsheets/d/" + sheetID + "/export?format=csv&gid=" + pageID;
            return url;
        }
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
}