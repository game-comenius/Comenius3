using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformadorDeObjeto : MonoBehaviour
{

    public GameObject objeto;


    public void MudarPosicaoX(int x)
    {
        objeto.transform.position = new Vector3((float)x, objeto.transform.position.y, objeto.transform.position.z);
    }

    public void MudarPosicaoY(int y)
    {
        objeto.transform.position = new Vector3(objeto.transform.position.x, (float)y, objeto.transform.position.z);
    }
}
