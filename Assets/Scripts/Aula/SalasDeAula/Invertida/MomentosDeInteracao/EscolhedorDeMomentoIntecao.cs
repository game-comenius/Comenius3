using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EscolhedorDeMomentoInteracao
{

    private static MomentoInteracao[] momentos;
    public static MomentoInteracao GetMomento()
    {
        if(momentos == null)
            momentos = Resources.LoadAll<MomentoInteracao>("MomentosInteracao/GeradosPelaPlanilha");

        //Pega um momento gerado pela da planilha
        return momentos[Random.Range(0, momentos.Length)];
    }
}
