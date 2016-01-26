using UnityEngine;
using System.Collections;

public class ReadyToChangeText : MonoBehaviour
{
    public bool IsOKToChangeText;

    void OnMouseDown()
    {
        IsOKToChangeText = true;
    }
}
