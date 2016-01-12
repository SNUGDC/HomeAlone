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
	}

	void OnMouseDown()
	{
		if (balloon.GetComponent<SpriteRenderer> () != null && istalking == false)
		{
			ChangeRendererState ();
			Invoke ("ChangeRendererState", 2.0f);
		}
	}

}
