using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class dragAndDropPuzzle : MonoBehaviour
{
    public GameObject seledtedPiece;
    int orderInLayer = 1;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<piecesScript>().inRightPosition)
                {
                    seledtedPiece = hit.transform.gameObject;
                    seledtedPiece.GetComponent<piecesScript>().selected = true;
                    seledtedPiece.GetComponent<SortingGroup>().sortingOrder = orderInLayer;
                    orderInLayer++;
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (seledtedPiece != null)
            {
                seledtedPiece.GetComponent<piecesScript>().selected = false;
                seledtedPiece = null;
            }
        }
        if (seledtedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            seledtedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }
}