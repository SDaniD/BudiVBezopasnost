using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class piecesScript : MonoBehaviour
{
    public Vector3 rightPosition;
    public bool inRightPosition;
    public bool selected;
    public GameObject next;
    public GameObject check;
    void Start()
    {
        rightPosition = transform.position;
        transform.position = new Vector3(Random.Range(1f,7f), Random.Range(3f, -3f));
    }
    
    void Update()
    {
        if (Vector3.Distance(transform.position, rightPosition) < 0.5f)
        {
            if (!selected)
            {
                if (inRightPosition == false)
                {
                    transform.position = rightPosition;
                    inRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0; 
                }
            }
        }
        if (inRightPosition == true)
        {
            next.SetActive(true);
            check.SetActive(true);
        }
    }
}
