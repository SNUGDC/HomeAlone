using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour
{
	public float movespeed;

	void Start ()
	{
		
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.RightArrow))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (movespeed, 0);
		} 
		else if (Input.GetKey (KeyCode.LeftArrow))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-movespeed, 0);
		}
		else
		{
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		}
	}
}
