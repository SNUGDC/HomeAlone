using UnityEngine;
using System.Collections;

public class QuitApplication : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
