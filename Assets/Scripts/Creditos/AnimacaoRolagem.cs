using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoRolagem : MonoBehaviour
{

    public GameObject ProducaoECoord;
    public GameObject GameDesign;
    public GameObject Arte;
    public GameObject Programacao;
    public GameObject Pedagogico;

    int velocidade = Screen.height / 12;
    float ProducaoECoordY, ProducaoECoordX;
    float GameDesignY, GameDesignX;
    float ArteY, ArteX;
    float ProgramacaoY, ProgramacaoX;
    float PedagogicoY, PedagogicoX;

    // Start is called before the first frame update
    void Start()
    {
        ProducaoECoordY = ProducaoECoord.transform.position.y;
        ProducaoECoordX = ProducaoECoord.transform.position.x;

        GameDesignY = GameDesign.transform.position.y;
        GameDesignX = GameDesign.transform.position.x;

        ArteY = Arte.transform.position.y;
        ArteX = Arte.transform.position.x;

        ProgramacaoY = Programacao.transform.position.y;
        ProgramacaoX = Programacao.transform.position.x;

        PedagogicoY = Pedagogico.transform.position.y;
        PedagogicoX = Pedagogico.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

        if (ProducaoECoord.transform.position.y < Screen.height - (Screen.height / 35)) {
            ProducaoECoord.transform.Translate(Vector3.up * Time.deltaTime * velocidade);
            GameDesign.transform.Translate(Vector3.up * Time.deltaTime * velocidade);
            Arte.transform.Translate(Vector3.up * Time.deltaTime * velocidade);
            Programacao.transform.Translate(Vector3.up * Time.deltaTime * velocidade);
            Pedagogico.transform.Translate(Vector3.up * Time.deltaTime * velocidade);
        } /*else {

            ProducaoECoord.transform.position = new Vector3(ProducaoECoordX, ProducaoECoordY, transform.position.z);
            GameDesign.transform.position = new Vector3(GameDesignX, GameDesignY, transform.position.z);
            Arte.transform.transform.position = new Vector3(ArteX, ArteY, transform.position.z);
            Programacao.transform.position = new Vector3(ProgramacaoX, ProgramacaoY, transform.position.z);
            Pedagogico.transform.position = new Vector3(PedagogicoX, PedagogicoY, transform.position.z);

        } */

        //Debug.Log(ProducaoECoord.transform.position.x + " " + ProducaoECoord.transform.position.y + " " + ProducaoECoord.transform.position.z);

    }
}
