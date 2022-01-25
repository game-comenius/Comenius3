using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Preview))]
public class PreviewEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var previewScript = target as Preview;

        string[] options = new string[]
        {
            "Preview de quartos", "Preview de salas Simples", "Preview de salas com Agrupamentos"
        };

        previewScript.selectedOption = EditorGUILayout.Popup("Opção", previewScript.selectedOption, options);

        switch (previewScript.selectedOption)
        {
            case 0:
                previewScript.quartoInfantil = EditorGUILayout.ObjectField("Quarto Infantil",
                                                                           previewScript.quartoInfantil,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.quartoFundamental = EditorGUILayout.ObjectField("Quarto Fundamental",
                                                                           previewScript.quartoFundamental,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.quartoMedio = EditorGUILayout.ObjectField("Quarto Médio",
                                                                           previewScript.quartoMedio,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.quartoSuperior = EditorGUILayout.ObjectField("Quarto Superior",
                                                                           previewScript.quartoSuperior,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;
                break;
            case 1:
                previewScript.salaInfantilIndividual = EditorGUILayout.ObjectField("Sala Infantil",
                                                                           previewScript.salaInfantilIndividual,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.salaRegularIndividual = EditorGUILayout.ObjectField("Sala Regular",
                                                                           previewScript.salaRegularIndividual,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;
                break;
            case 2:
                previewScript.salaInfantilU = EditorGUILayout.ObjectField("Sala Infantil U",
                                                                           previewScript.salaInfantilU,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.salaInfantilIndividual = EditorGUILayout.ObjectField("Sala Infantil Individual",
                                                                           previewScript.salaInfantilIndividual,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.salaInfantilDuplasETrios = EditorGUILayout.ObjectField("Sala Infantil Duplas e Trios",
                                                                           previewScript.salaInfantilDuplasETrios,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.salaInfantilGrandesGrupos = EditorGUILayout.ObjectField("Sala Infantil Grandes Grupos",
                                                                           previewScript.salaInfantilGrandesGrupos,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.salaRegularU = EditorGUILayout.ObjectField("Sala Regular U",
                                                                           previewScript.salaRegularU,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.salaRegularIndividual = EditorGUILayout.ObjectField("Sala Regular Individual",
                                                                           previewScript.salaRegularIndividual,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.salaRegularTrios = EditorGUILayout.ObjectField("Sala Regular Duplas e Trios",
                                                                           previewScript.salaRegularTrios,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.salaRegularGrandesGrupos = EditorGUILayout.ObjectField("Sala Regular Grandes Grupos",
                                                                           previewScript.salaRegularGrandesGrupos,
                                                                           typeof(Sprite),
                                                                           true) as Sprite;

                previewScript.segundoAgrupamento = EditorGUILayout.Toggle("Segundo Agrupamento",
                                                                          previewScript.segundoAgrupamento);
                break;
            default:
                Debug.LogWarning("Opção inválida no preview de quartos e salas");
                break;
        }
    }
}
