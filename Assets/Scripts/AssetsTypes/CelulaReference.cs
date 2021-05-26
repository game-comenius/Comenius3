using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CelulaReference
{
    public PlanilhaDoGoogle planilha;//Referencia de um scriptable objet do tipo planilha

    //Linha e coluna no qual está a celula desejada
    public int linha;
    public int coluna;

    [SerializeField, HideInInspector]
    private float propertyDrawerAux;//Variavel utilizada pelo custom property drawer

    [SerializeField]
    private string valor;
    public bool modoReferencia;//Modo onde não é utilizado o valor da célula e sim um no qual é possivél digitar

    //Getter/setter para o valor
    public string Valor
    {
        get
        {
            if (modoReferencia && planilha != null)
                valor = planilha.GetDataAt(linha, coluna);
            return valor;
        }
        set
        {
            valor = value;
        }
    }
}
