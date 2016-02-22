using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SleepingController : MonoBehaviour
{
    public int SleepPercent;
	public GameObject SleepImage;

    int RandomNumber;

    void Awake()
    {
        RandomNumber = Random.Range(0, 100);

        if (RandomNumber <= SleepPercent)
        {
            PlayerPrefs.SetString("PlayerPos", "bed1");
            Debug.Log("Sleep!");
			FriendList.bed1 = true;
        }
        else
        {
            PlayerPrefs.SetString("PlayerPos", "floor1");
            Debug.Log("Floor1");
			FriendList.floor1 = true;
        }
    }
}
