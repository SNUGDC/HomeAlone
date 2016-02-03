using UnityEngine;
using System.Collections;

public class ReadyToChangeText : MonoBehaviour
{
    public bool IsOKToChangeText = true;

    private bool IsShowed;

    void Start()
    {
        IsShowed = false;
    }

    void Update()
    {
        if (IsShowed == false)
        {
            IsOKToChangeText = true;
            IsShowed = true;
        }
    }

    void OnMouseDown()
    {
        IsOKToChangeText = true;
    }
}
