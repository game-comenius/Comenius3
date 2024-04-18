using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour
{
    
    public void ChangeLanguageNew(int num)
    {
        switch (num)
        {
            case 2:
                      Textos.TrocarIdioma(Idiomas.PORTUGUES);
                break;

            case 1:
                Textos.TrocarIdioma(Idiomas.INGLES);
                break;

            case 3:
                Textos.TrocarIdioma(Idiomas.ESPANHOL);
                break;
        }
      
    }
}
