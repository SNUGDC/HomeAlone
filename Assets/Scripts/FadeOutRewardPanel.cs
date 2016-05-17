using UnityEngine;
using System.Collections;

public class FadeOutRewardPanel : MonoBehaviour
{
    float time;

    void Start()
    {
        time = 0;
    }
	void Update ()
    {
        time = time + Time.deltaTime;
        if (time > 1)
            gameObject.SetActive(false);
    }
}
