﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BotaoNivelDeEnsino))]
public class BotaoNivelDeEnsinoEditor : Editor
{
    private int[] valoresDosNiveisDeEnsino;
    private string[] labelsDosNiveisDeEnsino;

    private SerializedProperty nivelDeEnsinoProperty;
    private SerializedProperty spriteGrande;

    private void Awake()
    {
        nivelDeEnsinoProperty = serializedObject.FindProperty("valorNivelDeEnsino");
        spriteGrande = serializedObject.FindProperty("SpriteGrande");
    }

    private void OnEnable()
    {
        var niveisDeEnsino = NivelDeEnsino.TodosOsNiveisDeEnsino();
        var quantidadeDeNiveis = niveisDeEnsino.Length;
        valoresDosNiveisDeEnsino = new int[quantidadeDeNiveis];
        labelsDosNiveisDeEnsino = new string[quantidadeDeNiveis];
        for (var i = 0; i < quantidadeDeNiveis; i++)
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

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PropertyField(spriteGrande);
        EditorGUILayout.EndHorizontal();

        serializedObject.ApplyModifiedProperties();
    }
}
