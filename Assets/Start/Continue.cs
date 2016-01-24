using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Main");
    }
}
