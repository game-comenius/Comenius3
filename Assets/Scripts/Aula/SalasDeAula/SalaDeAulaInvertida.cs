﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalaDeAulaInvertida : SalaDeAula
{
    public Midia midia1;
    public Midia midia2;
    // Start is called before the first frame update
    void Start()
    {
        midia1 = EstadoDoJogo.Instance.MidiasSelecionadas[0];
        midia2 = EstadoDoJogo.Instance.MidiasSelecionadas[1];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
