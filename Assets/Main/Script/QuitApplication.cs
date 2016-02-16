using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuitApplication : MonoBehaviour
{
    public GameObject UI_Quit;

	void start(){
		// screen direction fix
		Screen.orientation = ScreenOrientation.Landscape;
	}
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
