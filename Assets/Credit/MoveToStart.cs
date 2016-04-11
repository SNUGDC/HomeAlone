using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveToStart : MonoBehaviour
{
    void OnMouseUp()
    {
        SceneManager.LoadScene("Start");
    }
}
