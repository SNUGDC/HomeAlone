using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToCharacterStateScene : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("눌림");
        SceneManager.LoadScene("Character State");
    }
}
