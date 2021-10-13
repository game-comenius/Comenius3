using UnityEditor;

[CustomEditor(typeof(IconeInteligencias))]
public class IconeInteligenciasEditor : Editor
{
    private int[] valoresDosParesDeInteligencias;
    private string[] labelsDosParesDeInteligencias;

    private void OnEnable()
    {
        var paresDeInteligencias = Inteligencias.TodosOsParesDeInteligencias();
        var quantidade = paresDeInteligencias.Length;
        valoresDosParesDeInteligencias = new int[quantidade];
        labelsDosParesDeInteligencias = new string[quantidade];
        for (var i = 0; i < quantidade; i++)
        {
            valoresDosParesDeInteligencias[i] = paresDeInteligencias[i].valor;
            labelsDosParesDeInteligencias[i] = valoresDosParesDeInteligencias[i] + ": " + paresDeInteligencias[i].nome;
        }
    }

    public override void OnInspectorGUI()
    {
        var iconeInteligenciasScript = target as IconeInteligencias;

        iconeInteligenciasScript.valorInteligencias = EditorGUILayout.IntPopup("Nivel de Ensino",
                                                                               iconeInteligenciasScript.valorInteligencias,
                                                                               labelsDosParesDeInteligencias,
                                                                               valoresDosParesDeInteligencias);
        
        iconeInteligenciasScript.pagina = EditorGUILayout.ObjectField("Pagina",
                                                                      iconeInteligenciasScript.pagina,
                                                                      typeof(PaginaInteligencias),
                                                                      true) as PaginaInteligencias;
    }
}
