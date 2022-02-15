using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragAndDropvqrno2 : MonoBehaviour
{
    public static bool possitiontrue2;
    public static bool?  gendertrue2;
    [SerializeField]
    public Transform vqrnoMomche;
    public Transform vqrnoMomiche;
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
        if (Mathf.Abs(transform.position.x - vqrnoMomche.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - vqrnoMomche.position.y) <= 2.5f )
        {
            possitiontrue2 = true;
            gendertrue2 = true;
            Debug.Log("in boy");
        }
        else if(
            Mathf.Abs(transform.position.x - vqrnoMomiche.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - vqrnoMomiche.position.y) <= 2.5f)
        {
            possitiontrue2 = true;
            gendertrue2 = false;
            Debug.Log("in girl");
        }
        
           else {
            gendertrue2 = null;
            possitiontrue2 = false;
            Debug.Log("out");
            }
            
            
       
    }
}
