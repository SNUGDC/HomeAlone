using UnityEngine;
using System.Collections;

public class DecideCharacter : MonoBehaviour
{
	public GameObject JHInfo;

	public void Decide(string sceneToChangeTo)
	{
		if (JHInfo.GetComponent<SpriteRenderer> ().enabled == true)
		{
			Application.LoadLevel(sceneToChangeTo);
		}
	}
}
