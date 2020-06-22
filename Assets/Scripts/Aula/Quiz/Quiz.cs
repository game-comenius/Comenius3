using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Quiz : MonoBehaviour
{
    // Deve ser chamado como uma coroutine pelo StartCoroutine
    // Deve retornar quando o jogador responder o quiz completamente
    public abstract IEnumerator Executar();
}
