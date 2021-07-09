using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] SpriteRenderer corpo;
    [SerializeField] SpriteRenderer cabelo;
    [SerializeField] SpriteRenderer roupa;
    //Sprite Renderer dos Objetos
    public SpriteRenderer corpoSentado;
    public SpriteRenderer cabeloSentado;
    public SpriteRenderer roupaSentado;
    public SpriteRenderer almofadaSentado;
    //Sprites Setandos Femininos
    public Sprite cabeloFemininoSentado1;
    public Sprite cabeloFemininoSentado2;
    public Sprite cabeloFemininoSentado3;    
    public Sprite cabeloFemininoSentado4;
    public Sprite cabeloFemininoSentado5;
    public Sprite cabeloFemininoSentado6;
    public Sprite corpoFemininoSentado1;
    public Sprite corpoFemininoSentado2;
    public Sprite corpoFemininoSentado3;
    public Sprite roupaFemininoSentado1;
    public Sprite roupaFemininoSentado2;
    public Sprite roupaFemininoSentado3;
    public Sprite almofadaFeminino1;
    public Sprite almofadaFeminino2;
    public Sprite almofadaFeminino3;
    //Sprites Sentados Masculinos
    public Sprite cabeloMasculinoSentado1;
    public Sprite cabeloMasculinoSentado2;
    public Sprite cabeloMasculinoSentado3;
    public Sprite cabeloMasculinoSentado4;
    public Sprite cabeloMasculinoSentado5;
    public Sprite cabeloMasculinoSentado6;
    public Sprite corpoMasculinoSentado1;
    public Sprite corpoMasculinoSentado2;
    public Sprite corpoMasculinoSentado3;
    public Sprite roupaMasculinoSentado1;
    public Sprite roupaMasculinoSentado2;
    public Sprite roupaMasculinoSentado3;
    public Sprite almofadaMasculino1;
    public Sprite almofadaMasculino2;
    public Sprite almofadaMasculino3;
    //Variaveis utilizadas nos métodos
    Sprite spriteCorpo;
    Sprite spriteCabelo;
    Sprite spriteRoupa;
    Sprite spriteAlmofada;
    //Objetos que escondem e mostram os conjuntos de sprites sentados e de pé
    public GameObject personagemDePe;
    public GameObject personagemSentado;
    // Start is called before the first frame update
    void Start()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        //Checando o Nível de Ensino para saber se o sprite deve ser sentado ou em pé.
        if (estadoDoJogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil)
        {
            personagemDePe.SetActive(false);
            personagemSentado.SetActive(true);
            //Usando os métodos para achar os sprites equivalentes, utilizando o sprite de cabelo do personagem em pé como ponto de referência.
            cabeloSentado.sprite = acharCabeloSentado(estadoDoJogo.SpriteCabeloPersonagem);
            corpoSentado.sprite = acharCorpoSentado(estadoDoJogo.SpriteCabeloPersonagem);
            roupaSentado.sprite = acharRoupaSentado(estadoDoJogo.SpriteCabeloPersonagem);
            almofadaSentado.sprite = acharAlmofada(estadoDoJogo.SpriteCabeloPersonagem);
        } 
        else
        {
            personagemSentado.SetActive(false);
            personagemDePe.SetActive(true);
            if (estadoDoJogo.SpriteCorpoPersonagem) corpo.sprite = estadoDoJogo.SpriteCorpoPersonagem;
            if (estadoDoJogo.SpriteCabeloPersonagem) cabelo.sprite = estadoDoJogo.SpriteCabeloPersonagem;
            if (estadoDoJogo.SpriteRoupaPersonagem) roupa.sprite = estadoDoJogo.SpriteRoupaPersonagem;
        }
        
    }
    //Procurando o sprite equivalente com base no cabelo
    Sprite acharCabeloSentado(Sprite sprite)
    {
        switch (sprite.name)
        {
            case "CABELO FEMININO 1":
                spriteCabelo = cabeloFemininoSentado1;
                break;
            case "CABELO FEMININO 2":
                spriteCabelo = cabeloFemininoSentado2;
                break;
            case "CABELO FEMININO 3":
                spriteCabelo = cabeloFemininoSentado3;
                break;
            case "CABELO FEMININO 4":
                spriteCabelo = cabeloFemininoSentado4;
                break;
            case "CABELO FEMININO 5":
                spriteCabelo = cabeloFemininoSentado5;
                break;
            case "CABELO FEMININO 6":
                spriteCabelo = cabeloFemininoSentado6;
                break;
            case "CABELO MASCULINO 1":
                spriteCabelo = cabeloMasculinoSentado1;
                break;
            case "CABELO MASCULINO 2":
                spriteCabelo = cabeloMasculinoSentado2;
                break;
            case "CABELO MASCULINO 3":
                spriteCabelo = cabeloMasculinoSentado3;
                break;
            case "CABELO MASCULINO 4":
                spriteCabelo = cabeloMasculinoSentado4;
                break;
            case "CABELO MASCULINO 5":
                spriteCabelo = cabeloMasculinoSentado5;
                break;
            case "CABELO MASCULINO 6":
                spriteCabelo = cabeloMasculinoSentado6;
                break;
        }
        return spriteCabelo;
    }
    //Procurando o sprite equivalente com base no cabelo
    Sprite acharCorpoSentado(Sprite sprite)
    {        
        switch (sprite.name)
        {
            case "CABELO FEMININO 1":
                spriteCorpo = corpoFemininoSentado1;
                break;
            case "CABELO FEMININO 2":
                spriteCorpo = corpoFemininoSentado2;
                break;
            case "CABELO FEMININO 3":
                spriteCorpo = corpoFemininoSentado3;
                break;
            case "CABELO FEMININO 4":
                spriteCorpo = corpoFemininoSentado1;
                break;
            case "CABELO FEMININO 5":
                spriteCorpo = corpoFemininoSentado2;
                break;
            case "CABELO FEMININO 6":
                spriteCorpo = corpoFemininoSentado3;
                break;
            case "CABELO MASCULINO 1":
                spriteCorpo = corpoMasculinoSentado1;
                break;
            case "CABELO MASCULINO 2":
                spriteCorpo = corpoMasculinoSentado2;
                break;
            case "CABELO MASCULINO 3":
                spriteCorpo = corpoMasculinoSentado3;
                break;
            case "CABELO MASCULINO 4":
                spriteCorpo = corpoMasculinoSentado1;
                break;
            case "CABELO MASCULINO 5":
                spriteCorpo = corpoMasculinoSentado2;
                break;
            case "CABELO MASCULINO 6":
                spriteCorpo = corpoMasculinoSentado3;
                break;
        }
        return spriteCorpo;
    }
    //Procurando o sprite equivalente com base no cabelo
    Sprite acharRoupaSentado(Sprite sprite)
    {
        switch (sprite.name)
        {
            case "CABELO FEMININO 1":
                spriteRoupa = roupaFemininoSentado1;
                break;
            case "CABELO FEMININO 2":
                spriteRoupa = roupaFemininoSentado2;
                break;
            case "CABELO FEMININO 3":
                spriteRoupa = roupaFemininoSentado3;
                break;
            case "CABELO FEMININO 4":
                spriteRoupa = roupaFemininoSentado1;
                break;
            case "CABELO FEMININO 5":
                spriteRoupa = roupaFemininoSentado2;
                break;
            case "CABELO FEMININO 6":
                spriteRoupa = roupaFemininoSentado3;
                break;
            case "CABELO MASCULINO 1":
                spriteRoupa = roupaMasculinoSentado1;
                break;
            case "CABELO MASCULINO 2":
                spriteRoupa = roupaMasculinoSentado2;
                break;
            case "CABELO MASCULINO 3":
                spriteRoupa = roupaMasculinoSentado3;
                break;
            case "CABELO MASCULINO 4":
                spriteRoupa = roupaMasculinoSentado1;
                break;
            case "CABELO MASCULINO 5":
                spriteRoupa = roupaMasculinoSentado2;
                break;
            case "CABELO MASCULINO 6":
                spriteRoupa = roupaMasculinoSentado3;
                break;
        }
        return spriteRoupa;
    }
    //Procurando o sprite equivalente com base no cabelo
    Sprite acharAlmofada(Sprite sprite)
    {
        switch (sprite.name)
        {
            case "CABELO FEMININO 1":
                spriteAlmofada = almofadaFeminino1;
                break;
            case "CABELO FEMININO 2":
                spriteAlmofada = almofadaFeminino2;
                break;
            case "CABELO FEMININO 3":
                spriteAlmofada = almofadaFeminino3;
                break;
            case "CABELO FEMININO 4":
                spriteAlmofada = almofadaFeminino1;
                break;
            case "CABELO FEMININO 5":
                spriteAlmofada = almofadaFeminino2;
                break;
            case "CABELO FEMININO 6":
                spriteAlmofada = almofadaFeminino3;
                break;
            case "CABELO MASCULINO 1":
                spriteAlmofada = almofadaMasculino1;
                break;
            case "CABELO MASCULINO 2":
                spriteAlmofada = almofadaMasculino2;
                break;
            case "CABELO MASCULINO 3":
                spriteAlmofada = almofadaMasculino3;
                break;
            case "CABELO MASCULINO 4":
                spriteAlmofada = almofadaMasculino1;
                break;
            case "CABELO MASCULINO 5":
                spriteAlmofada = almofadaMasculino2;
                break;
            case "CABELO MASCULINO 6":
                spriteAlmofada = almofadaMasculino3;
                break;
        }
        return spriteAlmofada;
    }
}
