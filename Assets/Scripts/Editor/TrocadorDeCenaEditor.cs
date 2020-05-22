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

    private void Awake()
    {
        cenaAlvoProperty = serializedObject.FindProperty("IndiceDaCenaAlvo");
    }

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
        // Tirar o comentário da linha abaixo se quiser que o Unity Inspector
        // mostre os campos/propriedades do script do jeito padrão, ou seja,
        // como se não estivéssemos reescrevendo este jeito
        base.OnInspectorGUI();

        serializedObject.Update();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.PrefixLabel("Cena Alvo");
        cenaAlvoProperty.intValue = EditorGUILayout.IntPopup(cenaAlvoProperty.intValue, labelDasCenasDisponiveis, indicesDasCenasDisponiveis);
        EditorGUILayout.EndHorizontal();

        serializedObject.ApplyModifiedProperties();
    }
}
