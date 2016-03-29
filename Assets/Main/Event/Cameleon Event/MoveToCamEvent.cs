using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveToCamEvent : MonoBehaviour
{
    public void MoveToEvent()
    {
        SceneManager.LoadScene("Cameleon Event");
    }
}
