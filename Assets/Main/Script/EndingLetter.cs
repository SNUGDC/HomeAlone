using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndingLetter : MonoBehaviour
{
    public GameObject WarningMessage;

    void Start()
    {
        WarningMessage.SetActive(false);
        if (PlayerPrefs.GetString("IsEnding") != "True")
            Destroy(gameObject);
    }

    void OnMouseUp()
    {
        if (PlayerPrefs.GetString("WhatIsEnd") == "HappyEnding")
            SceneManager.LoadScene("HappyEnding");
        else if (PlayerPrefs.GetString("WhatIsEnd") == "RealEnding")
            WarningMessage.SetActive(true);
    }
}
