using UnityEngine;
using System.Collections;

public class SleepingController : MonoBehaviour
{
    public int SleepPercent;

    void Start()
    {
        if(Random.Range(0,7) <= SleepPercent)
        {
            Debug.Log("Player is Sleeping");
        }
    }
}
