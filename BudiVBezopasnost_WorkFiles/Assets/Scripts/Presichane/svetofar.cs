using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class svetofar : MonoBehaviour
{
    public float sec = 5f;
    public GameObject green;
    public GameObject red;
    void Update()
    {
        if (red.activeInHierarchy == true && green.activeInHierarchy == false)
        {
            red.SetActive(true);
            green.SetActive(false);
            StartCoroutine(LateCallRed());
        }
        else if(red.activeInHierarchy == false && green.activeInHierarchy == true)
        {
            green.SetActive(true);
            red.SetActive(false);
            StartCoroutine(LateCallGreen());
        }
        
    }

    IEnumerator LateCallRed()
    {

        yield return new WaitForSeconds(sec);

        green.SetActive(true);
        red.SetActive(false);
    }
    IEnumerator LateCallGreen()
    {

        yield return new WaitForSeconds(sec);

        red.SetActive(true);
        green.SetActive(false);
    }
}
