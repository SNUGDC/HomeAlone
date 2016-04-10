using UnityEngine;
using System.Collections;

public class GompangSpawnController : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("Month") > 9 || PlayerPrefs.GetInt("Month") < 7)
            Destroy(gameObject);
    }
}
