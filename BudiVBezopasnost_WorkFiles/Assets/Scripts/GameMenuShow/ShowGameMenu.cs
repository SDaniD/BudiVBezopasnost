using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGameMenu : MonoBehaviour
{
    public GameObject GameMenu;
    
    public void Enable()
    {
        GameMenu.SetActive(true);
    }
    public void Disable()
    {
        GameMenu.SetActive(false);
    }
}