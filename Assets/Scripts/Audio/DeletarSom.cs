using UnityEngine;

public class DeletarSom : MonoBehaviour
{

    AudioSource fonte;

    void Start()
    {
        fonte = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if (!fonte.isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
