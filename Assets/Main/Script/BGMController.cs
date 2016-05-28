using UnityEngine;
using System.Collections;

public class BGMController : MonoBehaviour
{
    public Sprite BGMOn;

    void Start()
    {
        if (PlayerPrefs.GetString("BGM") == "ON")
        {
            GetComponent<SpriteRenderer>().sprite = null;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = BGMOn;
        }
    }
}
