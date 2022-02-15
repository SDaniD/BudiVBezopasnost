using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obrushtaneSGrub : MonoBehaviour
{
    public GameObject momicheGrub;
    public GameObject momicheLiceRight;
    public GameObject momicheLiceLeft;
    private void OnTriggerStay2D(Collider2D collider)
    {
        momicheGrub.SetActive(true);
        momicheLiceRight.SetActive(false);
        momicheLiceLeft.SetActive(false);
    }
}
