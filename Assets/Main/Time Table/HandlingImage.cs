using UnityEngine;
using System.Collections;

public class HandlingImage : MonoBehaviour
{
    public GameObject[] ValueShower;
    public GameObject Section;
    public int Right;

    private int Left = 0;

    void Update()
    {
        ErrorChecker();

        Right = Section.GetComponent<SectionPositionToValue>().s;
        transform.position = new Vector3((ValueShower[Left].GetComponent<Transform>().position.x + ValueShower[Right].GetComponent<Transform>().position.x) / 2, 0, transform.position.z);
        transform.localScale = new Vector3((float)7.5*(Right - Left), 1, 1);
    }

    void ErrorChecker()
    {
        if (Right > 16)
            Right = 16;
        else if (Right < 0)
            Right = 0;
    }
}
