using UnityEngine;
using System.Collections;

public class HidePhoto : MonoBehaviour
{
    public GameObject Photo;
    public GameObject Room;

    void OnMouseUp()
    {
        Photo.SetActive(false);
        Room.SetActive(true);
    }
}
