using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeGroupMenu : MonoBehaviour
{
    public GameObject rightChoise;
    
    public void Enable()
    {
        rightChoise.SetActive(true);
    }
    public void Disable()
    {
        rightChoise.SetActive(false);
    }
}