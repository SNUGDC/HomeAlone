using UnityEngine;
using System.Collections;

public class SleepingController : MonoBehaviour
{
    public int SleepPercent;

    int RandomNumber;

    void Awake()
    {
        RandomNumber = Random.Range(0, 100);

        if (RandomNumber <= SleepPercent)
        {
            PlayerPrefs.SetString("PlayerPos", "bed1");
            Debug.Log("Sleep!");
        }
        else
        {
            PlayerPrefs.SetString("PlayerPos", "floor1");
            Debug.Log("Floor1");
        }
    }
}
