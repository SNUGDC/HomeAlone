using UnityEngine;
using System.Collections;

public class CharacterSelectEQ : MonoBehaviour
{
	public GameObject Block;

	public void ChangeBlockingRendererState()
	{
		if (Block.GetComponent<SpriteRenderer> ().enabled == false)
		{
			Block.GetComponent<SpriteRenderer> ().enabled = true;
			Debug.Log ("True");
		}
	}
}
