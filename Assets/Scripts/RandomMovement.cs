using UnityEngine;
using System.Collections;
using System;

public class RandomMovement : MonoBehaviour
{
    public string FieldName;

    float ran1;
    float ran2;
    bool IsOut;

    DateTime UpdatedTime;

    void Start()
    {
        ran2 = UnityEngine.Random.Range(-100, 100);
        IsOut = false;
    }

    void Update()
    {
        if (IsOut)
            return;
        if (System.DateTime.Now - UpdatedTime > new TimeSpan(0, 0, UnityEngine.Random.Range(3, 5)))
        {
            ran1 = UnityEngine.Random.Range(-100, 100);
            GetComponent<Rigidbody2D>().velocity = new Vector2(ran1 / 100, ran2 / 100);
            ran2 = ran1;
            UpdatedTime = System.DateTime.Now;
        }
    }

    void OnTriggerEnter2D(Collider2D Coll)
    {
        if(Coll.name == FieldName)
            IsOut = false;
    }

    void OnTriggerExit2D(Collider2D Coll)
    {
        if (Coll.name == FieldName)
        {
            IsOut = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-GetComponent<Rigidbody2D>().velocity.x, -GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
