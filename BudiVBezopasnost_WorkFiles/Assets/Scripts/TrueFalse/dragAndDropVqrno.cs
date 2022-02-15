using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragAndDropVqrno : MonoBehaviour
{ 
  
    public static bool possitiontrue;
    public static bool? gendertrue;
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
            gendertrue = true;
            possitiontrue = true;
            Debug.Log("in boy");
        }
        else if (Mathf.Abs(transform.position.x - vqrnoMomiche.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - vqrnoMomiche.position.y) <= 2.5f)
        {
            gendertrue = false;
            possitiontrue = true;
            Debug.Log("in girl");
        }
        else
        {
            gendertrue = null;
            possitiontrue = false;
            Debug.Log("out");
        }
    }
}
