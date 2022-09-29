using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CameraMapaControll : MonoBehaviour
{
    public Camera cameraMain;

    public Vector3[] locaisFoco;
    void Start()
    {
      var lugar =   EstadoDoJogo.Instance.Lugar = LocationChecker.EvaluateLocation();


        switch (lugar)
        {
            case LocationChecker.Location.Observatory:
                cameraMain.transform.position = locaisFoco[0];
                break;
            case LocationChecker.Location.Circus:
                cameraMain.transform.position = locaisFoco[1];
                break;
            case LocationChecker.Location.Aquarium:
                cameraMain.transform.position = locaisFoco[2];
                break;
            case LocationChecker.Location.Theater:
                cameraMain.transform.position = locaisFoco[3];
                break;
            case LocationChecker.Location.Library:
                cameraMain.transform.position = locaisFoco[4];
                break;
            case LocationChecker.Location.Museum:
                cameraMain.transform.position = locaisFoco[5];
                break;
            case LocationChecker.Location.Park:
                 cameraMain.transform.position = locaisFoco[6];
                break;
            case LocationChecker.Location.Radio:
                cameraMain.transform.position = locaisFoco[7];
                break;
            case LocationChecker.Location.University:
                cameraMain.transform.position = locaisFoco[8];
                break;
            case LocationChecker.Location.Cinema:
                cameraMain.transform.position = locaisFoco[9];
                break;
            case LocationChecker.Location.Gym:
                cameraMain.transform.position = locaisFoco[10];
                break;
            case LocationChecker.Location.Musical:
                cameraMain.transform.position = locaisFoco[11];
                break;
            case LocationChecker.Location.ResearchCenter:
                cameraMain.transform.position = locaisFoco[12];
                break;
            case LocationChecker.Location.Startup:
                cameraMain.transform.position = locaisFoco[13];
                break;
            case LocationChecker.Location.BotanicalGarden:
                cameraMain.transform.position = locaisFoco[14];
                break;
            case LocationChecker.Location.NGO:
                cameraMain.transform.position = locaisFoco[15];
                break;
        }
    }
}


