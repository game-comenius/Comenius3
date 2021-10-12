using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(IconeInteligencias))]
public class IconeInteligenciasEditor : Editor
{
    private int[] valoresDosParesDeInteligencias;
    private string[] labelsDosParesDeInteligencias;

    private SerializedProperty nivelDeEnsinoProperty;
    private SerializedProperty spriteGrande;

    private void Awake()
    {
        nivelDeEnsinoProperty = serializedObject.FindProperty("valorInteligencias");
        spriteGrande = serializedObject.FindProperty("SpriteGrande");
    }

    private void OnEnable()
    {
        var paresDeInteligencias = Inteligencias.TodosOsParesDeInteligencias();
        var quantidade = paresDeInteligencias.Length;
        valoresDosParesDeInteligencias = new int[quantidade];
        labelsDosParesDeInteligencias = new string[quantidade];
        for (var i = 0; i < quantidade; i++)
        {
            valoresDosParesDeInteligencias[i] = paresDeInteligencias[i].Valor;
            labelsDosParesDeInteligencias[i] = valoresDosParesDeInteligencias[i] + ": " + paresDeInteligencias[i].Nome;
        }
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("Par de Inteligências");
        nivelDeEnsinoProperty.intValue = EditorGUILayout.IntPopup(nivelDeEnsinoProperty.intValue, labelsDosParesDeInteligencias, valoresDosParesDeInteligencias);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PropertyField(spriteGrande);
        EditorGUILayout.EndHorizontal();

        serializedObject.ApplyModifiedProperties();
    }
}
