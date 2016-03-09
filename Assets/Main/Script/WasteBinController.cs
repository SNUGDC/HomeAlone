using UnityEngine;
using System.Collections;
using System;

public class WasteBinController : MonoBehaviour
{
    public int FullOfTrash;
    public Sprite DirtyTrashCan;
    public Sprite CleanTrashCan;

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
}