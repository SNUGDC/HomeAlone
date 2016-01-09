using UnityEngine;
using System.Collections;

public class ChangeStartScene : MonoBehaviour
{
	public void ChangeScene (string sceneToChangeTo)
	{
		Application.LoadLevel(sceneToChangeTo);
	}
}
