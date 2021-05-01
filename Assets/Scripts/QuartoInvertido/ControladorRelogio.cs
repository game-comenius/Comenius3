using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorRelogio : MonoBehaviour
{
    [SerializeField] GameObject relogio0;
    [SerializeField] GameObject relogio1;
    [SerializeField] GameObject relogio2;
    [SerializeField] GameObject relogio3;
    private int estado = 0;

    // Start is called before the first frame update
    void Start() {
        relogio0.SetActive(true);
        relogio1.SetActive(false);
        relogio2.SetActive(false);
        relogio3.SetActive(false);
    }

    public void OnClick() {

        if (estado < 4) {
            estado++;
        }

        switch (estado) {
            case 0:
                relogio0.SetActive(true);
                relogio1.SetActive(false);
                relogio2.SetActive(false);
                relogio3.SetActive(false);
                break;
            case 1:
                relogio0.SetActive(false);
                relogio1.SetActive(true);
                relogio2.SetActive(false);
                relogio3.SetActive(false);
                break;
            case 2:
                relogio0.SetActive(false);
                relogio1.SetActive(false);
                relogio2.SetActive(true);
                relogio3.SetActive(false);
                break;
            case 3:
                relogio0.SetActive(false);
                relogio1.SetActive(false);
                relogio2.SetActive(false);
                relogio3.SetActive(true);
                break;
            default:
                relogio0.SetActive(true);
                relogio1.SetActive(false);
                relogio2.SetActive(false);
                relogio3.SetActive(false);
                break;

        }
    }
}
