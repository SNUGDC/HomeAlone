using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToMainScene : MonoBehaviour
{
    void OnMouseUp()
    {
        SceneManager.LoadScene("Main");
    }
}
