using UnityEngine;
using System.Collections;

public class TapToClickedTimePlusOne : MonoBehaviour
{
    public GameObject button;
    public int ShowTime;

    void Update()
    {
        if (PenguinEventText.ClickedTime_PenguinEvent == ShowTime)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    void OnMouseDown()
    {
        PenguinEventText.ClickedTime_PenguinEvent = ShowTime + 1;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        button.SetActive(true);
    }
}