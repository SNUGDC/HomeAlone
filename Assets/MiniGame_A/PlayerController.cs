using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax;
}

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    public Boundary boundary;

    void FixedUpdate()
    {
		
        //float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(1.0f, 0.0f, 0.0f);
		/*
		if (Input.touchCount > 0) {
			Debug.Log ("heeeello");
			Touch touch = Input.GetTouch (0);
			if (touch.position.x > 0) {
				Debug.Log ("hello");
				GetComponent<Rigidbody> ().velocity = movement * speed;
			} else {
				GetComponent<Rigidbody> ().velocity = -movement * speed;
			}
		}*/
		if (Input.GetMouseButton (0)) {
			Debug.Log (Input.mousePosition.x);
			Debug.Log (Screen.width / 2);
			if (Input.mousePosition.x >= Screen.width / 2) {
				GetComponent<Rigidbody> ().velocity = movement * speed;
			} else {
				GetComponent<Rigidbody> ().velocity = -movement * speed;
			}
		} else {
			GetComponent<Rigidbody> ().velocity = -movement * 0;
		}

        GetComponent<Rigidbody>().position = new Vector3
            (
                Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
                -4.0f,
                0.0f
            );
    }


}
