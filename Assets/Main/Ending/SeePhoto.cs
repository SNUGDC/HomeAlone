using UnityEngine;
using System.Collections;

public class SeePhoto : MonoBehaviour
{
    public GameObject Photo;
    public GameObject Room;

    void Start()
    {
        Photo.SetActive(false);
        Room.SetActive(true);
    }

    void OnMouseUp()
    {
        Photo.SetActive(true);
        Room.SetActive(false);
    }
}
