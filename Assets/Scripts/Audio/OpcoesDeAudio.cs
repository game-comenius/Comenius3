using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OpcoesDeAudio :  MonoBehaviour
{
    AudioSource trilhaSonora;
    public DisplaySlider displaySlider;
    public GameObject sliderObject; // Referencia feita pelo inspetor
    Slider sliderScript;
    bool mutado = false; 
    float ultimoVolume;
    RawImage imagemBotaoAudio;
    public Texture botaoMutado;
    public Texture botao0;
    public Texture botao1;
    public Texture botao2;
    public Texture botaoLigado;
    // Start is called before the first frame update
    void Start()
    {
        //Referência do objeto da trilha sonora
        trilhaSonora = GameObject.Find("AudioManager/TrilhaSonora").GetComponent<AudioSource>();
        sliderScript = sliderObject.GetComponent<Slider>();
        // if (SceneManager.GetActiveScene().name == "Menu" && trilhaSonora.volume == 1f) { trilhaSonora.volume = 0.4f; }
        sliderScript.value = trilhaSonora.volume;//Queremos que o valor do slider seja o mesmo quando trocamos de cena.
        ultimoVolume = sliderScript.value;//O ultimoVolume também.
        imagemBotaoAudio = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        // Se o volume for zerado manualmente(sem apertar o botão de mutar), a variavel mutado sera considerada verdadeira.
        if (sliderScript.value == 0f)
        {            
            mutado = true;
        }
        else
        {
            mutado = false;
        }
        EstadoImagemDoBotao();
    }

    public void ControleDeVolume(float volume)
    {
        //Faz com que o volume da trilha sonora seja controlado pelo valor do slider(função chamada pelo inspetor no objeto slider)
        trilhaSonora.volume = volume;        
    }
    public void Mutar()
    {
        if (displaySlider.highLighted) {
            if (!mutado)
            {
                if(sliderScript.value != 0.0f)
                {
                    ultimoVolume = sliderScript.value;
                }
                sliderScript.value = 0;
                imagemBotaoAudio.texture = botaoMutado;
                imagemBotaoAudio.color = new Color(imagemBotaoAudio.color.r, imagemBotaoAudio.color.g, imagemBotaoAudio.color.b, 0.3f);
                mutado = true;
            }
            else
            {
                sliderScript.value = ultimoVolume;
                mutado = false;
            }
        }
    }
    void EstadoImagemDoBotao()
    {
        if(sliderScript.value == 0f)
        {
            imagemBotaoAudio.texture = botaoMutado;
            imagemBotaoAudio.color = new Color(imagemBotaoAudio.color.r, imagemBotaoAudio.color.g, imagemBotaoAudio.color.b, 0.3f);
        }
        else if (sliderScript.value > 0f && sliderScript.value <= 0.25f)
        {
            imagemBotaoAudio.texture = botao0;
            imagemBotaoAudio.color = new Color(imagemBotaoAudio.color.r, imagemBotaoAudio.color.g, imagemBotaoAudio.color.b, 1f);
        }
        else if (sliderScript.value > 0.25f && sliderScript.value <= 0.50f)
        {
            imagemBotaoAudio.texture = botao1;
            imagemBotaoAudio.color = new Color(imagemBotaoAudio.color.r, imagemBotaoAudio.color.g, imagemBotaoAudio.color.b, 1f);
        }
        else if (sliderScript.value > 0.50f && sliderScript.value <= 0.75f)
        {
            imagemBotaoAudio.texture = botao2;
            imagemBotaoAudio.color = new Color(imagemBotaoAudio.color.r, imagemBotaoAudio.color.g, imagemBotaoAudio.color.b, 1f);
        }
        else if (sliderScript.value > 0.75f && sliderScript.value <= 1)
        {
            imagemBotaoAudio.texture = botaoLigado;
            imagemBotaoAudio.color = new Color(imagemBotaoAudio.color.r, imagemBotaoAudio.color.g, imagemBotaoAudio.color.b, 1f);
        }
    }
}
