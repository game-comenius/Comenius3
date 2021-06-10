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
    public AudioClip menuTrilha, momentoDoCriadorTrilha, aulaTrilha, creditosTrilha;

    public GameObject gameObjectDaTrilhaAtual;

    //GameObject pro som
    public GameObject som;

    //public GameObject trilha;

    public GameObject trilhaInicial;

    //Componente audio source da trilha inicial
    AudioSource audioSourceTrilha;

    //public float volume;

    //Controle de cenas
    private string ultimaCena;

    //Impedir que a música pare no menu.
    bool jaIniciou = false;


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

        audioSourceTrilha = trilhaInicial.GetComponent<AudioSource>();
    }

    private void Update()
    {
        //Variável para comparação
        //Armazena constantemente a cena que está ativa no momento
        var cenaAtual = SceneManager.GetActiveScene().name;
        
        //Compara com a cena ativa por último para confirmar se ainda está na mesma cena ou trocou de cena
        if(cenaAtual != ultimaCena)
        {
            if (cenaAtual != "MenuPrincipal") {
                ultimaCena = cenaAtual;
                TocarTrilhaSonora();
                //Debug.Log(ultimaCena + " - Não é o menu" + " | Cena atual: " + cenaAtual);
            } else {
                if (jaIniciou == false) {
                    ultimaCena = cenaAtual;
                    TocarTrilhaSonora();
                    //Debug.Log(ultimaCena + " - Menu" + " | Cena atual: " + cenaAtual);
                    jaIniciou = true;
                }
            }
        }
        
    }


    public void TocarSFX(string nomeDoSFX)
    {
        switch (nomeDoSFX)
        {
            case "clique":
                
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
        //Criar o GameObject para o som a partir da prefab
        GameObject novoObjeto = Instantiate(som, transform);
        //Atribuir o clipe do som a sua fonte
        novoObjeto.GetComponent<AudioSource>().clip = clipe;
        //Tocar o SFX
        novoObjeto.GetComponent<AudioSource>().Play();
    }

    public void TocarTrilhaSonora()
    {
        //Troca trilha apenas se a cena em que o jogo se encontra for uma cena pré definida como gatilho para trocar trilha
        //Se não, trilha continua tocando normalmente
        switch (ultimaCena)
        {
            case "AulaABP":
                CriacaoGameObjectTrilhaSonora(aulaTrilha);
                jaIniciou = false;
                break;
            case "MenuPrincipal":
                CriacaoGameObjectTrilhaSonora(menuTrilha);
                break;
            case "Introdução":
                CriacaoGameObjectTrilhaSonora(momentoDoCriadorTrilha);
                break;
            case "Loading":
                trilhaInicial.GetComponent<AudioSource>().Stop();
                break;
            default:
                break;
        }
    }

    public void CriacaoGameObjectTrilhaSonora(AudioClip clipe)
    {
        //Criar o GameObject para o som a partir da prefab
        //gameObjectDaTrilhaAtual = Instantiate(trilha, transform);

        //Atribuir o clipe do som a sua fonte
        trilhaInicial.GetComponent<AudioSource>().clip = clipe;
        //Configurar a trilha para ficar em looping
        trilhaInicial.GetComponent<AudioSource>().loop = true;
        //Tocar o SFX
        trilhaInicial.GetComponent<AudioSource>().Play();
    }   
}
