using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class puzzleSelect : MonoBehaviour
{
    public GameObject MenuPuzzle;
    public void SetPuzzlesPhoto(Image Photo)
    {
        for (int i = 0; i < 9; i++)
        {
            GameObject.Find("Pieces (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
        MenuPuzzle.SetActive(false);
    }
}
