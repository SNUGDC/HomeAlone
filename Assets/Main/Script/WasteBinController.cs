using UnityEngine;
using System.Collections;
using System;

public class WasteBinController : MonoBehaviour
{
    public int FullOfTrash;
    public Sprite DirtyTrashCan;
    public Sprite CleanTrashCan;
    public GameObject UI_WasteBin;

    int Ran;
    bool IsFull;
    
    void Start()
    {
        Ran = UnityEngine.Random.Range(0, 100);

        if (Ran < FullOfTrash)
        {
            IsFull = true;
            GetComponent<SpriteRenderer>().sprite = DirtyTrashCan;
        }
        else
        {
            IsFull = false;
            GetComponent<SpriteRenderer>().sprite = CleanTrashCan;
        }
    }

    void OnMouseUp()
    {
        if (IsFull)
        {
            UI_WasteBin.SetActive(true);
        }
        else return;
    }

    public void CleaningWasteBin()
    {
        IsFull = false;
        GetComponent<SpriteRenderer>().sprite = CleanTrashCan;
        UI_WasteBin.SetActive(false);
    }
}