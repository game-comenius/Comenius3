using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance;

    //Tornar o script acessível em outros scripts
    public static AudioManager instance { get { return _instance; } }

    //Definição SFXs
    public AudioClip cliqueComumSFX, cliqueConfirmarSFX, estrelaEBarraSFX;

    //Definição trilha sonora
    public AudioClip menuTrilha, comeniusELurdinhaTrilha, aulaTrilha;

    public GameObject gameObjectDaTrilhaAtual;

    //GameObject pro som
    public GameObject som;

    public GameObject trilha;

    //Controle de cenas
    private string ultimaCena;


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

        //Armazena a cena que foi ativa por último
        ultimaCena = SceneManager.GetActiveScene().name;


        //Se não existir um gameObject com uma trilha sonora, criar um
        if (gameObjectDaTrilhaAtual == false)
        {
            TocarTrilhaSonora();
        }
    }

    private void Update()
    {
        //Variável para comparação
        //Armazena constantemente a cena que está ativa no momento
        var cenaAtual = SceneManager.GetActiveScene().name;
        
        //Compara com a cena ativa por último para confirmar se ainda está na mesma cena ou trocou de cena
        if(cenaAtual != ultimaCena)
        {
            ultimaCena = cenaAtual;
            TocarTrilhaSonora();
        }

    }

    private void Start()
    {
    }


    public void TocarSFX(string nomeDoSFX)
    {
        switch (nomeDoSFX)
        {
            case "clique":

                Debug.Log("Tocar chamado");
                CriacaoGameObjectSom(cliqueComumSFX);
                break;
            case "confirmar":
                CriacaoGameObjectSom(cliqueConfirmarSFX);
                break;
            case "estrela":
                CriacaoGameObjectSom(estrelaEBarraSFX);
                break;
            default:
                break;
        }
    }

    public void CriacaoGameObjectSom(AudioClip clipe)
    {
        Debug.Log("Criar chamado");

        //Criar o GameObject para o som a partir da prefab
        GameObject novoObjeto = Instantiate(som, transform);
        //Atribuir o clipe do som a sua fonte
        novoObjeto.GetComponent<AudioSource>().clip = clipe;
        //Tocar o SFX
        novoObjeto.GetComponent<AudioSource>().Play();

        Debug.Log(clipe);
    }

    public void TocarTrilhaSonora()
    {
        Debug.Log(ultimaCena);


        //Troca trilha apenas se a cena em que o jogo se encontra for uma cena pré definida como gatilho para trocar trilha
        //Se não, trilha continua tocando normalmente
        switch (ultimaCena)
        {
            case "AulaABP":
                CriacaoGameObjectTrilhaSonora(aulaTrilha);
                break;
            case "MenuPrincipal":
                CriacaoGameObjectTrilhaSonora(menuTrilha);
                break;
            case "Introdução":
                CriacaoGameObjectTrilhaSonora(comeniusELurdinhaTrilha);
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
        gameObjectDaTrilhaAtual = Instantiate(trilha, transform);
        //Atribuir o clipe do som a sua fonte
        gameObjectDaTrilhaAtual.GetComponent<AudioSource>().clip = clipe;
        //Configurar a trilha para ficar em looping
        gameObjectDaTrilhaAtual.GetComponent<AudioSource>().loop = true;
        //Tocar o SFX
        gameObjectDaTrilhaAtual.GetComponent<AudioSource>().Play();
    }

}
