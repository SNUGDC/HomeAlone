using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToStartScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            SceneManager.LoadScene("Start");
    }
}
