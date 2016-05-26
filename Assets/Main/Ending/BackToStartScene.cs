using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToStartScene : MonoBehaviour
{
	void Start(){
		if(PlayerPrefs.GetString("WhatIsEnd") == "RealEnding")
			PlayerPrefs.SetString ("SeeAfterReadlEnding", "True");
	}

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            SceneManager.LoadScene("Start");
    }
}
