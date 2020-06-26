using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(IconeAreaDeConhecimento))]
public class IconeAreaDeConhecimentoEditor : Editor
{
    private int[] valoresDasAreasDeConhecimento;
    private string[] labelsDasAreasDeConhecimento;

    private SerializedProperty areaDeConhecimentoProperty;
    private SerializedProperty spriteGrande;

    private void Awake()
    {
        areaDeConhecimentoProperty = serializedObject.FindProperty("valorAreaDeConhecimento");
        spriteGrande = serializedObject.FindProperty("SpriteGrande");
    }

    private void OnEnable()
    {
        var areasDeConhecimento = AreaDeConhecimento.TodasAsAreasDeConhecimento();
        var quantidadeDeAreas = areasDeConhecimento.Length;
        valoresDasAreasDeConhecimento = new int[quantidadeDeAreas];
        labelsDasAreasDeConhecimento = new string[quantidadeDeAreas];
        for (var i = 0; i < quantidadeDeAreas; i++)
        {
            valoresDasAreasDeConhecimento[i] = areasDeConhecimento[i].valor;
            labelsDasAreasDeConhecimento[i] = valoresDasAreasDeConhecimento[i] + ": " + areasDeConhecimento[i].nome;
        }
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("Área de Conhecimento");
        areaDeConhecimentoProperty.intValue = EditorGUILayout.IntPopup(areaDeConhecimentoProperty.intValue, labelsDasAreasDeConhecimento, valoresDasAreasDeConhecimento);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PropertyField(spriteGrande);
        EditorGUILayout.EndHorizontal();

        serializedObject.ApplyModifiedProperties();
    }
}
