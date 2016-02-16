using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuitApplication : MonoBehaviour
{
    public GameObject UI_Quit;

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            UI_Quit.SetActive(true);
        }
    }

    public void Quit()
    {
            Application.Quit();
    }
}
