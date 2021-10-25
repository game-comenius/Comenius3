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

    public enum TrilhasSonoras
    {
        MenuPrincipal,
        Planejamento,
        AulaABP
    }

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

    private void Start()
    {
        // Toca a trilha sonora inicial
        TocarTrilhaSonoraPainel("MenuPrincipal");
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

    // Overload para o novo sistema de interfaces
    public void TocarTrilhaSonoraPainel(string trilhaSonora)
    {
        switch (trilhaSonora)
        {
            case "AulaABP":
                CriacaoGameObjectTrilhaSonora(aulaTrilha);
                jaIniciou = false;
                break;
            case "MenuPrincipal":
                CriacaoGameObjectTrilhaSonora(menuTrilha);
                break;
            case "Planejamento":
                CriacaoGameObjectTrilhaSonora(momentoDoCriadorTrilha);
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
