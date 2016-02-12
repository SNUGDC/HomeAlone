using UnityEngine;
using System.Collections;
using System;

public class DustRandomMovement : MonoBehaviour
{
    float ran1;
    float ran2;

    DateTime UpdatedTime;

    void Start()
    {
        ran2 = UnityEngine.Random.Range(-100, 100);
    }

    void Update()
    {
        if (System.DateTime.Now - UpdatedTime > new TimeSpan(0, 0, UnityEngine.Random.Range(3, 5)))
        {
            ran1 = UnityEngine.Random.Range(-100, 100);
            GetComponent<Rigidbody2D>().velocity = new Vector2(ran1 / 100, ran2 / 100);
            ran2 = ran1;
            UpdatedTime = System.DateTime.Now;
        }
    }
}
