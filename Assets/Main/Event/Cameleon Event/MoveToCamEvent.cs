using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveToCamEvent : MonoBehaviour
{
    public void MoveToEvent()
    {
		PlayerPrefs.SetString ("CameleonEventShow","True");
        SceneManager.LoadScene("Cameleon Event");
    }
}
