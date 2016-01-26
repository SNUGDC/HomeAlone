using UnityEngine;
using System.Collections;

public class SectionPositionToValue : MonoBehaviour
{
    public int s;
    public GameObject NextSection;

    private Vector3 SectionPosition;
    public int NextS;


    void Update()
    {
        NextS = NextSection.GetComponent<SectionPositionToValue>().s;
        SectionPosition = transform.position;
        ErrorCheck();

        WhatISValue();
        CorrectPosition();
    }

    void ErrorCheck()
    {
        if (SectionPosition.x < -6)
            s = 0;
        if (SectionPosition.x > 6)
            s = 16;
    }

    void WhatISValue()
    {
        if (NextS < s)
        {
            s = NextS;
        }
        else
        {
            if (SectionPosition.x > 5.625)
                s = 16;
            else if (SectionPosition.x > 4.875)
                s = 15;
            else if (SectionPosition.x > 4.125)
                s = 14;
            else if (SectionPosition.x > 3.375)
                s = 13;
            else if (SectionPosition.x > 2.625)
                s = 12;
            else if (SectionPosition.x > 1.875)
                s = 11;
            else if (SectionPosition.x > 1.125)
                s = 10;
            else if (SectionPosition.x > 0.375)
                s = 9;
            else if (SectionPosition.x > -0.375)
                s = 8;
            else if (SectionPosition.x > -1.125)
                s = 7;
            else if (SectionPosition.x > -1.875)
                s = 6;
            else if (SectionPosition.x > -2.625)
                s = 5;
            else if (SectionPosition.x > -3.375)
                s = 4;
            else if (SectionPosition.x > -4.125)
                s = 3;
            else if (SectionPosition.x > -4.875)
                s = 2;
            else if (SectionPosition.x > -5.625)
                s = 1;
            else if (SectionPosition.x > -6.375)
                s = 0;
        }
    }

    void CorrectPosition()
    {
        switch (s)
        {
        case 0:
            transform.position = new Vector3(-6, 0, 0);
            break;
        case 1:
            transform.position = new Vector3((float)-5.25, 0, 0);
            break;
        case 2:
            transform.position = new Vector3((float)-4.5, 0, 0);
            break;
        case 3:
            transform.position = new Vector3((float)-3.75, 0, 0);
            break;
        case 4:
            transform.position = new Vector3(-3, 0, 0);
            break;
        case 5:
            transform.position = new Vector3((float)-2.25, 0, 0);
            break;
        case 6:
            transform.position = new Vector3((float)-1.5, 0, 0);
            break;
        case 7:
            transform.position = new Vector3((float)-0.75, 0, 0);
            break;
        case 8:
            transform.position = new Vector3(0, 0, 0);
            break;
        case 9:
            transform.position = new Vector3((float)0.75, 0, 0);
            break;
        case 10:
            transform.position = new Vector3((float)1.5, 0, 0);
            break;
        case 11:
            transform.position = new Vector3((float)2.25, 0, 0);
            break;
        case 12:
            transform.position = new Vector3(3, 0, 0);
            break;
        case 13:
            transform.position = new Vector3((float)3.75, 0, 0);
            break;
        case 14:
            transform.position = new Vector3((float)4.5, 0, 0);
            break;
        case 15:
            transform.position = new Vector3((float)5.25, 0, 0);
            break;
        case 16:
            transform.position = new Vector3(6, 0, 0);
            break;
        default:
            Debug.Log("뭔가 잘못되었다!!");
            break;
        }
    }
}
