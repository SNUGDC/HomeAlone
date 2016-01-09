using UnityEngine;
using System.Collections;

public class OutButton : MonoBehaviour
{
	public GameObject JHInfo;

	public void Out ()
	{
		if(JHInfo.GetComponent<SpriteRenderer> ().enabled==true)
		{
			JHInfo.GetComponent<SpriteRenderer> ().enabled = false;
			Debug.Log ("False");
		}
	}
}
