using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FlagDeEstadoDeJogo
{
    public FlagDeEstadoDeJogo(string _nome, bool _valor)
    {
        nome = _nome;
        valor = _valor;
    }
    public string nome;
    public bool valor;
}
