using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambulance : MonoBehaviour
{
    public static bool truePossition;
    [SerializeField]
    public Transform earth;


    private Vector2 initialPosition;

    private Vector2 mousePosition;

    private float deltaX, deltaY;


    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {

        deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;


    }
    private void OnMouseDrag()
    {

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
    }
    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - earth.position.x) <= 9f &&
            Mathf.Abs(transform.position.y - earth.position.y) <= 2.5f)
        {
            truePossition = true;
            Debug.Log("true");
        }
        else
        {
            truePossition = false;
            Debug.Log("false2");
        }
    }
}
