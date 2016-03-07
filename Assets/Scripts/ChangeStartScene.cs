using UnityEngine;
using System.Collections;

public class ChangeStartScene : MonoBehaviour
{
	void Start()
    {
        // screen direction fix
        Screen.orientation = ScreenOrientation.Landscape;
	}
	public void ChangeScene (string sceneToChangeTo)
	{
		Application.LoadLevel(sceneToChangeTo);
	}
}
