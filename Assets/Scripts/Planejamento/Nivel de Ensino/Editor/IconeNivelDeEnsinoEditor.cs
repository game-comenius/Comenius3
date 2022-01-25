using UnityEditor;

[CustomEditor(typeof(IconeNivelDeEnsino))]
public class IconeNivelDeEnsinoEditor : Editor
{
    private int[] valoresDosNiveisDeEnsino;
    private string[] labelsDosNiveisDeEnsino;

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
        var iconeNivelDeEnsinoScript = target as IconeNivelDeEnsino;

        iconeNivelDeEnsinoScript.valorNivelDeEnsino = EditorGUILayout.IntPopup("Nivel de Ensino",
                                                                               iconeNivelDeEnsinoScript.valorNivelDeEnsino,
                                                                               labelsDosNiveisDeEnsino,
                                                                               valoresDosNiveisDeEnsino);
        
        iconeNivelDeEnsinoScript.pagina = EditorGUILayout.ObjectField("Pagina",
                                                                      iconeNivelDeEnsinoScript.pagina,
                                                                      typeof(PaginaNivelDeEnsino),
                                                                      true) as PaginaNivelDeEnsino;
    }
}
