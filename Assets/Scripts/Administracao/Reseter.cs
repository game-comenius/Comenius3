using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reseter : MonoBehaviour
{
    private void Start()
    {
        EstadoDoJogo.Instance.ResetMetodologia();
    }
}
