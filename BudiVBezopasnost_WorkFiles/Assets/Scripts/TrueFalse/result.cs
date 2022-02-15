using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class result : MonoBehaviour
{

    public GameObject button;
    public GameObject image;
    public void Button1()
    {



        int finalResult = 0;
       
        
       //  plus

        if (dragAndDropGreshno.possitionfalse  == true)
        {
            finalResult++;
            Debug.Log("+");

        }
        if (dragAndDropVqrno.possitiontrue == true)
        {
            finalResult++;
            Debug.Log("+");
        }
        if (dragAndDropgreshno2.possitionfalse2 == true)
        {
            finalResult++;
            Debug.Log("+");
        }
        if (dragAndDropvqrno2.possitiontrue2 == true)
        {
            finalResult++;
            Debug.Log("+");
        }

        // gender

        if (dragAndDropGreshno.genderfalse == true && dragAndDropgreshno2.genderfalse2 == true || dragAndDropGreshno.genderfalse == false && dragAndDropgreshno2.genderfalse2 == false)
        {
            Debug.Log("suvpadatfalse--");
            finalResult--;
        }
         else 
         {
            Debug.Log("ne suvpadat false");
            
        }

         if (dragAndDropVqrno.gendertrue == true && dragAndDropvqrno2.gendertrue2 == true || dragAndDropVqrno.gendertrue == false && dragAndDropvqrno2.gendertrue2 == false)
         {
            Debug.Log("suvpadattrue--");
            finalResult--;
        }
         else
         {
            Debug.Log("ne suvpadat true");
        }


        // checkforerrors



        if (finalResult == 4)
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
