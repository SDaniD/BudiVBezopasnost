using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obrushtaneSLice : MonoBehaviour
{
    public GameObject momicheGrub;
    public GameObject momicheLiceRight;
    public GameObject momicheLiceLeft;
    private void OnTriggerStay2D(Collider2D collider)
    {
        momicheGrub.SetActive(false);
        momicheLiceRight.SetActive(true);
        momicheLiceLeft.SetActive(false);
    }
}
