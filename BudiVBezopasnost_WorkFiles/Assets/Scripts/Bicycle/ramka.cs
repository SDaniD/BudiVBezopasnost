using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramka : MonoBehaviour
{
    public static bool truePossition;
    [SerializeField]
    public Transform slot_pedal;
    public Transform slot_sedalka;
    public Transform slot_ramka;
    public Transform slot_rukohvatka;
    public Transform slot_prednipirachki;
    public Transform slot_spici;
    public Transform slot_guma;
    public Transform slot_zybniKolela;
    public Transform slot_veriga;
    public Transform slot_zadniSpirashki;


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
        if (Mathf.Abs(transform.position.x - slot_pedal.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - slot_pedal.position.y) <= 0.5f)
        {
            transform.position = new Vector2(slot_pedal.position.x, slot_pedal.position.y);
            truePossition = false;
            Debug.Log("false");
        }
        //2
        else if (Mathf.Abs(transform.position.x - slot_sedalka.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - slot_sedalka.position.y) <= 0.5f)
        {
            transform.position = new Vector2(slot_sedalka.position.x, slot_sedalka.position.y);
            truePossition = false;
            Debug.Log("false");
        }
        //3
        else if (Mathf.Abs(transform.position.x - slot_rukohvatka.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - slot_rukohvatka.position.y) <= 0.5f)
        {
            transform.position = new Vector2(slot_rukohvatka.position.x, slot_rukohvatka.position.y);
            truePossition = false;
            Debug.Log("false");
        }
        //4
        else if (Mathf.Abs(transform.position.x - slot_prednipirachki.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - slot_prednipirachki.position.y) <= 0.5f)
        {
            transform.position = new Vector2(slot_prednipirachki.position.x, slot_prednipirachki.position.y);
            truePossition = false;
            Debug.Log("false");
        }
        //5
        else if (Mathf.Abs(transform.position.x - slot_spici.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - slot_spici.position.y) <= 0.5f)
        {
            transform.position = new Vector2(slot_spici.position.x, slot_spici.position.y);
            truePossition = false;
            Debug.Log("false");
        }
        //6
        else if (Mathf.Abs(transform.position.x - slot_zybniKolela.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - slot_zybniKolela.position.y) <= 0.5f)
        {
            transform.position = new Vector2(slot_zybniKolela.position.x, slot_zybniKolela.position.y);
            truePossition = false;
            Debug.Log("false");
        }
        //7
        else if (Mathf.Abs(transform.position.x - slot_veriga.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - slot_veriga.position.y) <= 0.5f)
        {
            transform.position = new Vector2(slot_veriga.position.x, slot_veriga.position.y);
            truePossition = false;
            Debug.Log("false");
        }
        //8
        else if (Mathf.Abs(transform.position.x - slot_zadniSpirashki.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - slot_zadniSpirashki.position.y) <= 0.5f)
        {
            transform.position = new Vector2(slot_zadniSpirashki.position.x, slot_zadniSpirashki.position.y);
            truePossition = false;
            Debug.Log("false");
        }
        //9
        else if (Mathf.Abs(transform.position.x - slot_guma.position.x) <= 1f &&
          Mathf.Abs(transform.position.y - slot_guma.position.y) <= 0.5f)
        {
            transform.position = new Vector2(slot_guma.position.x, slot_guma.position.y);
            truePossition = false;
            Debug.Log("false");
        }
        //10
        else if (Mathf.Abs(transform.position.x - slot_ramka.position.x) <= 1f &&
          Mathf.Abs(transform.position.y - slot_ramka.position.y) <= 0.5f)
        {
            transform.position = new Vector2(slot_ramka.position.x, slot_ramka.position.y);
            truePossition = true;
            Debug.Log("true");
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }
}
