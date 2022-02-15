using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class restartBicycle : MonoBehaviour
{ 
    public GameObject pedal; 
    [SerializeField]
    private Transform slot_pedal;

    private Vector2 initialPosition;
    public static bool locked1;

    public void Restart()
    {

       transform.position = new Vector2(slot_pedal.position.x, slot_pedal.position.y);
        locked1 = false;


    }
       

   
 
}






   

