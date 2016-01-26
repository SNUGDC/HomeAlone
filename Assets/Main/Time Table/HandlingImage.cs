using UnityEngine;
using System.Collections;

public class HandlingImage : MonoBehaviour
{
    public GameObject[] ValueShower;
    public int Left = 0, Right;

    void Update()
    {
        transform.position = new Vector3((ValueShower[Left].GetComponent<Transform>().position.x + ValueShower[Right].GetComponent<Transform>().position.x) / 2, 0, 0);
        transform.localScale = new Vector3((float)7.5*(Right - Left), 1, 1);
    }
}
