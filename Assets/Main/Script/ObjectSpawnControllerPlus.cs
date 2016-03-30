using UnityEngine;
using System.Collections;

public class ObjectSpawnControllerPlus : MonoBehaviour
{
    public GameObject Sheep;
    public GameObject Croco;

    public bool HowFriendlyWithSheepCroc()
    {
        if(Sheep.GetComponent<Friend>().HowFriendly() > 1 && Croco.GetComponent<Friend>().HowFriendly() > 1)
            return true;
        else return false;
    }

    public bool WillGompangSpawn()
    {
        if (PlayerPrefs.GetInt("Month") <= 9 && PlayerPrefs.GetInt("Month") >= 7)
            return true;
        else return false;
    }
}
