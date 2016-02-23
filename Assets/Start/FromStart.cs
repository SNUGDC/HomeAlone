using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FromStart : MonoBehaviour
{
    void OnMouseDown()
    {
        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene("Tutorial");
    }
}
