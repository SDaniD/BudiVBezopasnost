using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ed : MonoBehaviour
{
    private bool isDragged;
    public bool truePlace;
    void OnMouseDown()
    {
        isDragged = true;
    }
    void OnMouseUp()
    {
        isDragged = false;
    }
    void Update()
    {
        if (isDragged)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
