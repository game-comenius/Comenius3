using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;

    //Tornar o script acessível em outros scripts
    public static AudioManager instance { get { return _instance; } }

    //Definição SFXs
    public AudioClip cliqueSFX, desligarSFX, popUpSFX, estrelinhaSFX;

    //Definição trilha sonora
    public AudioClip menuTrilha, comeniusTrilha, lurdinhaTrilha, feedbackTrilha;

    public GameObject gameObjectDaTrilhaAtual;

    //GameObject pro som
    public GameObject som;


    private void Awake()
    {

        if (_instance != null && _instance != this)
        {
            //Não ter sobreposições de gameObjects
            Destroy(this.gameObject);
        }
        else
        {
            //Carregar dados de áudio para outras cenas
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }

    public void TocarSFX(string nomeDoSFX)
    {
        switch (nomeDoSFX)
        {
            case "clique":
                CriacaoGameObjectSom(cliqueSFX);
                break;
            case "desligar":
                CriacaoGameObjectSom(desligarSFX);
                break;
            case "popUpSFX":
                CriacaoGameObjectSom(popUpSFX);
                break;
            case "estrela":
                CriacaoGameObjectSom(estrelinhaSFX);
                break;
            default:
                break;
        }
    }

    public void CriacaoGameObjectSom(AudioClip clipe)
    {
        //Criar o GameObject para o som a partir da prefab
        GameObject novoObjeto = Instantiate(som, transform);
        //Atribuir o clipe do som a sua fonte
        novoObjeto.GetComponent<AudioSource>().clip = clipe;
        //Tocar o SFX
        novoObjeto.GetComponent<AudioSource>().Play();

        
    }

    public void TocarTrilhaSonora(string nomeDaMusica)
    {
        switch (nomeDaMusica)
        {
            case "menu":
                CriacaoGameObjectTrilhaSonora(menuTrilha);
                break;
            case "comenius":
                CriacaoGameObjectTrilhaSonora(comeniusTrilha);
                break;
            case "lurdinha":
                CriacaoGameObjectTrilhaSonora(lurdinhaTrilha);
                break;
            case "feedback":
                CriacaoGameObjectTrilhaSonora(feedbackTrilha);
                break;
            default:
                break;
        }
    }

    public void CriacaoGameObjectTrilhaSonora(AudioClip clipe)
    {
        //Checar se já existe um gameObject da trilha sonora, se existir, deletar
        if (gameObjectDaTrilhaAtual)
        {
            Destroy(gameObjectDaTrilhaAtual);
        }
        //Criar o GameObject para o som a partir da prefab
        gameObjectDaTrilhaAtual = Instantiate(som, transform);
        //Atribuir o clipe do som a sua fonte
        gameObjectDaTrilhaAtual.GetComponent<AudioSource>().clip = clipe;
        //Configurar a trilha para ficar em looping
        gameObjectDaTrilhaAtual.GetComponent<AudioSource>().loop = true;
        //Tocar o SFX
        gameObjectDaTrilhaAtual.GetComponent<AudioSource>().Play();


    }

}
