﻿using UnityEngine;
using System.Collections;

public class ShowAdsPaper : MonoBehaviour
{
    public GameObject Advertisement1;
    public GameObject Advertisement2;
    public GameObject Advertisement3;
    public GameObject Advertisement4;

    void Start()
    {
        int RandomNumber = Random.Range(1, 100);

        if (RandomNumber < 25)
        {
            Advertisement2.SetActive(false);
            Advertisement3.SetActive(false);
            Advertisement4.SetActive(false);
        }
        else if (RandomNumber >= 25 && RandomNumber < 50)
        {
            Advertisement1.SetActive(false);
            Advertisement3.SetActive(false);
            Advertisement4.SetActive(false);
        }
        else if (RandomNumber >= 50 && RandomNumber < 75)
        {
            Advertisement1.SetActive(false);
            Advertisement2.SetActive(false);
            Advertisement4.SetActive(false);
        }
        else if (RandomNumber >= 75)
        {
            Advertisement1.SetActive(false);
            Advertisement2.SetActive(false);
            Advertisement3.SetActive(false);
        }
    }
}