using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LivingPoint : MonoBehaviour {
	public GameObject[] Dust;
	public Text[] Value;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DustUpdate(){
		if (DustController.DefaultDustCatch > 0) {
			Dust[0].SetActive (true);
			Value [0].text = "잡은 횟수: " + DustController.DefaultDustCatch;
		}

		if (BigDustController.BigDustCatch > 0) {
			Dust[1].SetActive (true);
			Value [1].text = "잡은 횟수: " + BigDustController.BigDustCatch;
		}
	}

}
