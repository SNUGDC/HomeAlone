using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Start");
    }
}
