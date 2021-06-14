using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;
using UnityEngine.Networking;

[CustomEditor(typeof(PlanilhaDoGoogle))]
public class PlanilhaDoGoogleInspector : Editor
{
    PlanilhaDoGoogle myTarget;
    SerializedProperty sheetID;
    SerializedProperty pageID;

    private UnityWebRequest _webRequest;

    private void OnEnable()
    {
        myTarget = target as PlanilhaDoGoogle;
        // Link the properties
        sheetID = serializedObject.FindProperty("sheetID");
        pageID = serializedObject.FindProperty("pageID");
    }


    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(sheetID);
        EditorGUILayout.PropertyField(pageID);

        EditorGUILayout.Space(20);

        DrawTable();

        if (GUILayout.Button("Update from GDrive"))
        {
            MakeRequest();
        }

        if (GUILayout.Button("Open sheet"))
        {
            Application.OpenURL("https://docs.google.com/spreadsheets/d/" + myTarget.sheetID);
        }

        if (GUI.changed)
        {
            EditorUtility.SetDirty(target);
            EditorUtility.SetDirty(myTarget);
        }
        serializedObject.ApplyModifiedProperties();
        Repaint();
    }

    private void DrawTable()
    {
        if (myTarget.data == null)
        {
            EditorGUILayout.LabelField("Não há dados!");
            return;
        }

        EditorGUILayout.LabelField("Tabela: ");

        EditorGUI.BeginDisabledGroup(true);
        for (int linha = 0; linha < myTarget.quantidadeDeLinhas; linha++)
        {
            EditorGUILayout.BeginHorizontal();
            for (int coluna = 0; coluna < myTarget.quantidadeDeColunas; coluna++)
            {
                EditorGUILayout.TextArea(myTarget.GetDataAt(linha, coluna), GUILayout.Width((EditorGUIUtility.currentViewWidth - 35) / myTarget.quantidadeDeColunas), GUILayout.ExpandHeight(true));
            }
            EditorGUILayout.EndHorizontal();
        }
        EditorGUI.EndDisabledGroup();
    }

    public void MakeRequest()
    {
        _webRequest = UnityWebRequest.Get(myTarget.Url);
        _webRequest.SendWebRequest();
        Debug.Log("Web request realizado!");
        EditorApplication.update += CheckForImportRequestEnd;
    }

    //Monitora o request e chama as funcoes de processamento dos dados
    private void CheckForImportRequestEnd()
    {

        if (_webRequest != null && _webRequest.isDone)
        {
            EditorApplication.update -= CheckForImportRequestEnd;
            if (_webRequest.isNetworkError || _webRequest.isHttpError)
            {
                Debug.Log(_webRequest.error);
                return;
            }


            var contentData = _webRequest.downloadHandler.text;


            myTarget.data = ParseData(contentData);
            Debug.Log("Dados atualizados com sucesso!");
        }
    }

    //Funcao de processamento dos dados
    private string[] ParseData(string contentData)
    {
        //Divide o CSV por linhas
        string[] linhas = CSVHelper.GetLines(contentData);


        //Calcula quantidade de linhas e colunas
        myTarget.quantidadeDeLinhas = linhas.Length;

        myTarget.quantidadeDeColunas = CSVHelper.GetColumnsFromLine(linhas[0]).Length;
        ////Loop para achar a quantidade correta de colunas, achando a linha com a maior quantidade de colunas
        foreach (string linha in linhas)
        {
            int colunasNaLinha = CSVHelper.GetColumnsFromLine(linha).Length;
            if (colunasNaLinha > myTarget.quantidadeDeColunas)
                myTarget.quantidadeDeColunas = colunasNaLinha;
        }



        //Divide as linhas nas celulas
        List<string> data = new List<string>();

        for (int linha = 0; linha < myTarget.quantidadeDeLinhas; linha++)
        {
            string[] celulasDaLinha = CSVHelper.GetColumnsFromLine(linhas[linha]);

            data.AddRange(celulasDaLinha);
        }

        return data.ToArray();
    }

}

public static class CSVHelper

//Funcao especial para nas considerar as quebras de linha dentro das celulas do csv
{
    public static string[] GetLines(string csvText)
    {
        char aSplitChar = '\n';
        string[] pieces = csvText.Split(aSplitChar);
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
                if (!last.Contains(","))
                {
                    string newLast = "";
                    foreach (char charI in last.ToCharArray())
                    {
                        if (charI != c)
                            newLast += charI;
                    }
                    last = newLast;
                }

                result[result.Count - 1] = last;
            }
            else
            {
                result.Add(piece);
            }
            if (piece.Contains(c.ToString()))//Se contem " comeca/para de reparar
            {
                int contagem = 0;
                foreach (char _c in piece.ToCharArray())
                {
                    if (_c == c)
                        contagem++;
                }
                //Verifica entao se essa peça esta "danificada"
                if (contagem < 2)
                {
                    repairing = !repairing;
                }

            }
        }
        return result.ToArray();
    }

    public static string[] GetColumnsFromLine(string line)
    {
        char aSplitChar = ',';
        string[] pieces = line.Split(aSplitChar);
        bool repairing = false;

        char c = '"';

        List<string> result = new List<string>();

        foreach (string piece in pieces)
        {

            if (repairing)
            {
                string last = result[result.Count - 1];


                last = last + "," + piece;

                result[result.Count - 1] = last;
            }
            else
            {
                result.Add(piece);
            }
            if (piece.Contains(c.ToString()))//Se contem " comeca/para de reparar
            {
                int contagem = 0;
                foreach (char _c in piece.ToCharArray())
                {
                    if (_c == c)
                        contagem++;
                }
                //Verifica entao se essa peça esta "danificada"
                if (contagem < 2)
                {
                    repairing = !repairing;
                }

            }
        }

        List<string> returnList = new List<string>();
        //Remove o caracter " (aspas duplas)
        foreach (string piece in result)
        {
            string newPiece = "";
            foreach (char charI in piece.ToCharArray())
            {
                if (charI != c)
                    newPiece += charI;
            }
            returnList.Add(newPiece);
        }
        return returnList.ToArray();
    }

}