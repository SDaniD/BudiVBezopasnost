using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMark : MonoBehaviour
{
    public GameObject check;
    void Update()
    {
        if (check.activeInHierarchy != true)
        {
            check.SetActive(true);
        }
    }
}
