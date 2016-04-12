using UnityEngine;
using System.Collections;

public class DestoryAfterDelay : MonoBehaviour
{
    public int delay;
    float k;

    void Update()
    {
        k += Time.deltaTime;

        if (k > delay)
            Destroy(gameObject);
    }
}
