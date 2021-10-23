using UnityEditor;

[CustomEditor(typeof(IconeMetodologia))]
public class IconeMetodologiaEditor : Editor
{
    private int[] valoresDosNiveisDeEnsino;
    private string[] labelsDosNiveisDeEnsino;

    private void OnEnable()
    {
        var niveisDeEnsino = Metodologia.TodasAsMetodologias();
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
        var iconeNivelDeEnsinoScript = target as IconeMetodologia;

        iconeNivelDeEnsinoScript.valorMetodologia = EditorGUILayout.IntPopup("Metodologia",
                                                                               iconeNivelDeEnsinoScript.valorMetodologia,
                                                                               labelsDosNiveisDeEnsino,
                                                                               valoresDosNiveisDeEnsino);

        iconeNivelDeEnsinoScript.pagina = EditorGUILayout.ObjectField("Pagina",
                                                                      iconeNivelDeEnsinoScript.pagina,
                                                                      typeof(PaginaMetodologia),
                                                                      true) as PaginaMetodologia;
    }
}
