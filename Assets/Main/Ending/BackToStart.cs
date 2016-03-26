using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
            SceneManager.LoadScene("Start");
    }
}
