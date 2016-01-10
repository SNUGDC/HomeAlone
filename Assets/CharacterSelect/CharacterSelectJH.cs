using UnityEngine;
using System.Collections;

public class CharacterSelectJH : MonoBehaviour
{
	public GameObject JHInfo;

	public void ChangeRendererState()
	{
		if (JHInfo.GetComponent<SpriteRenderer> ().enabled == false)
		{
			JHInfo.GetComponent<SpriteRenderer> ().enabled = true;
			Debug.Log ("True");
		}
	}
}
