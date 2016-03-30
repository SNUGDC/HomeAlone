using UnityEngine;
using System.Collections;

public class ObjectSpawnController : MonoBehaviour
{
    public int Probability;

    int k;

    void Start()
    {
        k = UnityEngine.Random.Range(0, 100);
        if (k > Probability)
            Destroy(gameObject);
    }
}
