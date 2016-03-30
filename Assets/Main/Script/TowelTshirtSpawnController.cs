using UnityEngine;
using System.Collections;

public class TowelTshirtSpawnController : MonoBehaviour
{
    public GameObject Sheep;
    public GameObject Croco;

    void Start ()
    {
        if (Sheep.GetComponent<Friend>().HowFriendly() <= 1 || Croco.GetComponent<Friend>().HowFriendly() <= 1)
            Destroy(gameObject);
    }
}
