using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BotaoMetodologia))]
public class BotaoMetodologiaEditor : Editor
{
    private int[] valoresDasMetodologias;
    private string[] labelsDasMetodologias;

    private SerializedProperty metodologiaProperty;
    private SerializedProperty spriteGrande;

    private void Awake()
    {
        metodologiaProperty = serializedObject.FindProperty("valorMetodologia");
        spriteGrande = serializedObject.FindProperty("SpriteGrande");
    }

    private void OnEnable()
    {
        var metodologias = Metodologia.TodasAsMetodologias();
        var quantidadeDeMetodologia = metodologias.Length;
        valoresDasMetodologias = new int[quantidadeDeMetodologia];
        labelsDasMetodologias = new string[quantidadeDeMetodologia];
        for (var i = 0; i < quantidadeDeMetodologia; i++)
        {
            valoresDasMetodologias[i] = metodologias[i].valor;
            labelsDasMetodologias[i] = valoresDasMetodologias[i] + ": " + metodologias[i].nome;
        }
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("Metodologia");
        metodologiaProperty.intValue = EditorGUILayout.IntPopup(metodologiaProperty.intValue, labelsDasMetodologias, valoresDasMetodologias);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PropertyField(spriteGrande);
        EditorGUILayout.EndHorizontal();

        serializedObject.ApplyModifiedProperties();
    }
}
