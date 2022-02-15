using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proverka : MonoBehaviour
{

    public GameObject button;
    public GameObject image;
    public void Button()
    {
        int finalResult = 0;


        //  plus

        if (pedal.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        else 
        {
            finalResult--;
            Debug.Log("-");
        }
         if (guma.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        else
        {
            finalResult--;
            Debug.Log("-");
        }
        if (predniSpirachki.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        else
        {
            finalResult--;
            Debug.Log("-");
        }
        if (ramka.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        else
        {
            finalResult--;
            Debug.Log("-");
        }
        if (rukohvatka.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        else
        {
            finalResult--;
            Debug.Log("-");
        }
        if (sedalka.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        else
        {
            finalResult--;
            Debug.Log("-");
        }
        if (spici.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        else
        {
            finalResult--;
            Debug.Log("-");
        }
        if (veriga.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        else
        {
            finalResult--;
            Debug.Log("-");
        }
        if (zadniSpirachki.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        else
        {
            finalResult--;
            Debug.Log("-");
        }
        if (zubniKolela.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        else
        {
            finalResult--;
            Debug.Log("-");
        }


        if (finalResult == 10)
        {
            button.SetActive(true);
            image.SetActive(true);
            Debug.Log("bravo");
        }
        if (finalResult != 10)
        {
            button.SetActive(false);
            Debug.Log("opitai pak");
        }
    }
}
