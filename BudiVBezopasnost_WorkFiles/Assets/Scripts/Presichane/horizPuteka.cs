using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class horizPuteka : MonoBehaviour
{
    public GameObject red;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        do
        {
            if (red.activeInHierarchy == true && heart1.activeInHierarchy != false)
            {
                heart1.SetActive(false);
            }
            else if (red.activeInHierarchy == true && heart1.activeInHierarchy == false && heart2.activeInHierarchy != false)
            {
                heart2.SetActive(false);
            }
            else if (red.activeInHierarchy == true && heart1.activeInHierarchy == false && heart2.activeInHierarchy == false && heart3.activeInHierarchy != false)
            {
                heart3.SetActive(false);
            }
            else if (red.activeInHierarchy == true && heart1.activeInHierarchy == false && heart2.activeInHierarchy == false && heart3.activeInHierarchy == false && heart4.activeInHierarchy != false)
            {
                heart4.SetActive(false);
            }
            else if (red.activeInHierarchy == true && heart1.activeInHierarchy == false && heart2.activeInHierarchy == false && heart3.activeInHierarchy == false && heart4.activeInHierarchy == false && heart5.activeInHierarchy != false)
            {
                heart5.SetActive(false);
            }
            else if (red.activeInHierarchy == true && heart1.activeInHierarchy == false && heart2.activeInHierarchy == false && heart3.activeInHierarchy == false && heart4.activeInHierarchy == false && heart5.activeInHierarchy == false)
            {
                ResetScene();
            }
            else if (red.activeInHierarchy != true )
            {
                int heart = 0;
                if (heart5.activeInHierarchy == false)
                {
                    ResetScene();
                }
                if (heart4.activeInHierarchy == false)
                {
                    heart++;
                }
                if (heart3.activeInHierarchy == false)
                {
                    heart++;
                }
                if (heart2.activeInHierarchy == false)
                {
                    heart++;
                }
                if (heart1.activeInHierarchy == false)
                {
                    heart++;
                }
                if (heart == 1)
                {
                    heart1.SetActive(true);
                }
                if (heart == 2)
                {
                    heart2.SetActive(true);
                }
                if (heart == 3)
                {
                    heart3.SetActive(true);
                }
                if (heart == 4)
                {
                    heart4.SetActive(true);
                }
                if (heart == 5)
                {
                    heart5.SetActive(true);
                }
            }
            break;
        } while (heart1.activeInHierarchy == true && heart2.activeInHierarchy == true && heart3.activeInHierarchy == true && heart4.activeInHierarchy == true && heart5.activeInHierarchy == true);
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
