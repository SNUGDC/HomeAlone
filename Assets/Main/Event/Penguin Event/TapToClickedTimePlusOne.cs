using UnityEngine;
using System;
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
            try
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
            catch(NullReferenceException e)
            {
                
            }
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    void OnMouseUp()
    {
        PenguinEventText.ClickedTime_PenguinEvent = ShowTime + 1;
        GetComponent<SpriteRenderer>().enabled = false;
        try
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        catch(NullReferenceException e)
        {
            
        }
        GetComponent<BoxCollider2D>().enabled = false;
        button.SetActive(true);
    }
}