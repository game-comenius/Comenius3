using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

[CustomEditor(typeof(PlanilhaDoGoogle))]
public class PlanilhaDoGoogleInspector : Editor
{
    PlanilhaDoGoogle myTarget;
    SerializedProperty sheetID;
    SerializedProperty pageID;

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
            myTarget.MakeRequest();
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
                EditorGUILayout.TextArea(myTarget.data[linha * myTarget.quantidadeDeColunas + coluna], GUILayout.Width((EditorGUIUtility.currentViewWidth-35)/ myTarget.quantidadeDeColunas), GUILayout.ExpandHeight(true)) ;
            }
            EditorGUILayout.EndHorizontal();
        }
        EditorGUI.EndDisabledGroup();
    }

}