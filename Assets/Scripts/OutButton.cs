using UnityEngine;
using System.Collections;

public class OutButton : MonoBehaviour
{
	public GameObject JHInfo;
    public GameObject CTInfo;
    public GameObject EQInfo;
    public GameObject SMInfo;
    public GameObject OutInfo;

	public void Out ()
	{
		JHInfo.GetComponent<SpriteRenderer> ().enabled = false;
        CTInfo.GetComponent<SpriteRenderer>().enabled = false;
        EQInfo.GetComponent<SpriteRenderer>().enabled = false;
        SMInfo.GetComponent<SpriteRenderer>().enabled = false;
        OutInfo.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log ("All False");
	}
}
