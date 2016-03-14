using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{
    private float LifeTime = 1.5f;

    void Start()
    {
        Destroy (gameObject, LifeTime);
    }

}
