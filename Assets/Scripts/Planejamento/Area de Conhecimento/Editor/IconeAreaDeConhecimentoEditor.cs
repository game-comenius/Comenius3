using UnityEditor;

[CustomEditor(typeof(IconeAreaDeConhecimento))]
public class IconeAreaDeConhecimentoEditor : Editor
{
    private int[] valoresDasAreasDeConhecimento;
    private string[] labelsDasAreasDeConhecimento;

    private void OnEnable()
    {
        var areasDeConhecimento = AreaDeConhecimento.TodasAsAreasDeConhecimento();
        var quantidadeDeAreas = areasDeConhecimento.Length;
        valoresDasAreasDeConhecimento = new int[quantidadeDeAreas];
        labelsDasAreasDeConhecimento = new string[quantidadeDeAreas];

        for (var i = 0; i < quantidadeDeAreas; i++)
        {
            valoresDasAreasDeConhecimento[i] = areasDeConhecimento[i].valor;
            labelsDasAreasDeConhecimento[i] = valoresDasAreasDeConhecimento[i] + ": " + areasDeConhecimento[i].nome;
        }
    }

    public override void OnInspectorGUI()
    {
        var iconeAreaDeConhecimentoScript = target as IconeAreaDeConhecimento;

        iconeAreaDeConhecimentoScript.valorAreaDeConhecimento = EditorGUILayout.IntPopup("Area de Conhecimento",
                                                                                         iconeAreaDeConhecimentoScript.valorAreaDeConhecimento,
                                                                                         labelsDasAreasDeConhecimento,
                                                                                         valoresDasAreasDeConhecimento);
        
        iconeAreaDeConhecimentoScript.pagina = EditorGUILayout.ObjectField("Pagina",
                                                                           iconeAreaDeConhecimentoScript.pagina,
                                                                           typeof(PaginaAreaDeConhecimento),
                                                                           true) as PaginaAreaDeConhecimento;
    }
}
