using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    public GameObject button;
    public GameObject image;
    public void Button1()
    {



        int finalResult = 0;


        //  +

        if (boat.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        if (bigboat.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");
        }
        if (SecondPlane.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");
        }
        if (bigBoat2.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");
        }
        if (ambulance.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");
        }
        if (taxi.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");
        }
        if (motor.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");
        }
        if (car.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");
        }
        if (bus.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");
        }
        if (Plain.truePossition == true)
        {
            finalResult++;
            Debug.Log("+");
        }
        

       

       

      //result


        if (finalResult == 10)
        {
            button.SetActive(true);
            image.SetActive(true);
            Debug.Log("button");
        }
        else
        {
            button.SetActive(false);
            Debug.Log("hide button");
        }
    }
}
