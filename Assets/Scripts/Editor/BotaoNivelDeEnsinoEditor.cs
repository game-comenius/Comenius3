using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BotaoNivelDeEnsino))]
public class BotaoNivelDeEnsinoEditor : Editor
{
    private int[] valoresDosNiveisDeEnsino;
    private string[] labelsDosNiveisDeEnsino;

    private SerializedProperty nivelDeEnsinoProperty;

    private void Awake()
    {
        nivelDeEnsinoProperty = serializedObject.FindProperty("valorNivelDeEnsino");
    }

    private void OnEnable()
    {
        var niveisDeEnsino = NivelDeEnsino.TodosOsNiveisDeEnsino();
        var quantidadeDeCenasDisponiveis = niveisDeEnsino.Length;
        valoresDosNiveisDeEnsino = new int[quantidadeDeCenasDisponiveis];
        labelsDosNiveisDeEnsino = new string[quantidadeDeCenasDisponiveis];
        for (var i = 0; i < quantidadeDeCenasDisponiveis; i++)
        {
            valoresDosNiveisDeEnsino[i] = niveisDeEnsino[i].valor;
            labelsDosNiveisDeEnsino[i] = valoresDosNiveisDeEnsino[i] + ": " + niveisDeEnsino[i].nome;
        }
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("Nivel De Ensino");
        nivelDeEnsinoProperty.intValue = EditorGUILayout.IntPopup(nivelDeEnsinoProperty.intValue, labelsDosNiveisDeEnsino, valoresDosNiveisDeEnsino);
        EditorGUILayout.EndHorizontal();

        serializedObject.ApplyModifiedProperties();
    }
}
