using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EstadoDoJogoDebugger))]
public class EstadoDeJogoDebuggerInspector : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUI.BeginDisabledGroup(true);
        base.OnInspectorGUI();
        EditorGUI.EndDisabledGroup();
        if(GUILayout.Button("Update Data"))
        {
            (target as EstadoDoJogoDebugger).UpdateData();
        }
    }
}
