using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EstadoDoJogoDebugger))]
public class EstadoDeJogoDebuggerInspector : Editor
{
    public override void OnInspectorGUI()
    {
        var debuggerScript = target as EstadoDoJogoDebugger;

        debuggerScript.updateOnInit = EditorGUILayout.Toggle("Update on initialization", debuggerScript.updateOnInit);

        EditorGUI.BeginDisabledGroup(!debuggerScript.updateOnInit);
        base.OnInspectorGUI();
        EditorGUI.EndDisabledGroup();

        if(GUILayout.Button("Write Data"))
        {
            debuggerScript.WriteData();
        }
        else if (GUILayout.Button("Read Data"))
        {
            debuggerScript.ReadData();
        }
    }
}
