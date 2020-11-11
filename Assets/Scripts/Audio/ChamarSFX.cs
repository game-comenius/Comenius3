using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamarSFX : MonoBehaviour
{
  public void ChamarSFXParaTocar(string nomeSFX)
    {
        AudioManager.instance.TocarSFX(nomeSFX);
    }
    
}
