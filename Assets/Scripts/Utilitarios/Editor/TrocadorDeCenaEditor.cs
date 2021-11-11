using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CustomEditor(typeof(TrocadorDeCena))]
public class TrocadorDeCenaEditor : Editor
{
    private int[] indicesDasCenasDisponiveis;
    private string[] labelDasCenasDisponiveis;

    private SerializedProperty cenaAlvoProperty;
    private void OnEnable()
    {
        
        var quantidadeDeCenasDisponiveis = SceneManager.sceneCountInBuildSettings;
        indicesDasCenasDisponiveis = new int[quantidadeDeCenasDisponiveis];
        labelDasCenasDisponiveis = new string[quantidadeDeCenasDisponiveis];
        for (var i = 0; i < quantidadeDeCenasDisponiveis; i++)
        {
            indicesDasCenasDisponiveis[i] = i;
            var caminhoDaCena = SceneUtility.GetScenePathByBuildIndex(i);
            var labelDaCena = Path.GetFileNameWithoutExtension(caminhoDaCena);
            labelDasCenasDisponiveis[i] = i + ": " + labelDaCena;
        }
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        cenaAlvoProperty = serializedObject.FindProperty("IndiceDaCenaAlvo");

        serializedObject.Update();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("Cena Alvo");

        cenaAlvoProperty.intValue = EditorGUILayout.IntPopup(cenaAlvoProperty.intValue, labelDasCenasDisponiveis, indicesDasCenasDisponiveis);
        EditorGUILayout.EndHorizontal();

        serializedObject.ApplyModifiedProperties();
    }
}
