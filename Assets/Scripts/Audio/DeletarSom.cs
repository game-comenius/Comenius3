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
            Debug.Log(name + " Parou de tocar");
            Destroy(gameObject);
        }
    }
}
