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
        rend.material.SetFloat("_OutlineEnabled", 1f);
    }

    void OnMouseExit()
    {
        rend.material.SetFloat("_OutlineEnabled", 0f);
    }
}
