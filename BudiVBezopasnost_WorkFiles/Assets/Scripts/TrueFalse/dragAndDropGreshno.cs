using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dragAndDropGreshno : MonoBehaviour
{
    public static  bool possitionfalse;
    public static bool? genderfalse;
    [SerializeField]
   public Transform greshnoMomche;
    public Transform greshnoMomiche;
    private Vector2 initialPosition;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    public static bool locked;
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
        if (Mathf.Abs(transform.position.x - greshnoMomche.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - greshnoMomche.position.y) <= 2.5f
            )
        {
            genderfalse = true;
            possitionfalse = true;
            Debug.Log("in boy");
        }
        else if (
            Mathf.Abs(transform.position.x - greshnoMomiche.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - greshnoMomiche.position.y) <= 2.5f)
        {
            possitionfalse = true;
            genderfalse = false;
            Debug.Log("in girl");
        }
        else
        {
            genderfalse = null;
            possitionfalse = false;
            Debug.Log("out");
        }
            
        }
    }

