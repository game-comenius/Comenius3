using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class OutlineOnHover : MonoBehaviour
{
    private Renderer rend;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnMouseEnter() 
    {
        Debug.Log("Entrou");
        rend.sharedMaterial.SetFloat("_OutlineEnabled", 1f);
    }

    void OnMouseExit() 
    {
        Debug.Log("Saiu");
        rend.sharedMaterial.SetFloat("_OutlineEnabled", 0f);
    }
}
