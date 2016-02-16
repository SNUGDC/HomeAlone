using UnityEngine;
using System.Collections;
using System;

public class CreateDust : MonoBehaviour
{
    public GameObject Dust1;
    public GameObject Dust2;
    public GameObject Dust3;
    public GameObject Dust4;
    public GameObject Dust5;
    public int DeltaTime;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;
    int k;

    void Start()
    {
        SysTime = System.DateTime.Now;
        Delta = new TimeSpan(0, 0, DeltaTime);
        UpdatedTime = SysTime;
    }

    void Update()
    {
        k = UnityEngine.Random.Range(1, 5);
        SysTime = System.DateTime.Now;
        if (TimeOver())
        {
            UpdatedTime = SysTime;

            switch(k)
            {
                case 1:
                    Instantiate(Dust1);
                    break;
                case 2:
                    Instantiate(Dust2);
                    break;
                case 3:
                    Instantiate(Dust3);
                    break;
                case 4:
                    Instantiate(Dust4);
                    break;
                case 5:
                    Instantiate(Dust5);
                    break;
                default:
                    Instantiate(Dust1);
                    break;
            }
        }
    }


    bool TimeOver()
    {
        if (SysTime - UpdatedTime >= Delta)
        {
            return true;
        }
        else return false;
    }
}
