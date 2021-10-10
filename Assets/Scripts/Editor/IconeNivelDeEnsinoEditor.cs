using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(IconeNivelDeEnsino))]
public class IconeNivelDeEnsinoEditor : Editor
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

        serializedObject.ApplyModifiedProperties();
    }
}
