using UnityEngine;
using System.Collections;

public class ObjectSpawnController : MonoBehaviour
{
    public int Probability;
    public GameObject ObjectConditionObject;

    int k;

    void Start()
    {
        k = UnityEngine.Random.Range(0, 100);
        if (k > Probability || !(ObjectConditionObject.GetComponent<Item>().haveItem()))
            Destroy(gameObject);
    }
}
