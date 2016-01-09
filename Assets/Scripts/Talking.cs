using UnityEngine;
using System.Collections;

public class Talking : MonoBehaviour
{
	public GameObject balloon;
	public bool istalking;

	void Start()
	{
		istalking = false;
	}

	void ChangeRendererState()
	{
		balloon.GetComponent<SpriteRenderer> ().enabled = !balloon.GetComponent<SpriteRenderer> ().enabled;
		istalking = !istalking;
		Debug.Log ("Change");
	}

	void OnMouseDown()
	{
		Debug.Log("mouse");

		if (balloon.GetComponent<SpriteRenderer> () != null && istalking == false)
		{
			ChangeRendererState ();
			Invoke ("ChangeRendererState", 2.0f);
		}
	}

}
