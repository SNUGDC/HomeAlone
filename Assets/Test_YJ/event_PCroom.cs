using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class event_PCroom : MonoBehaviour {
	
	public int iValue; // 스킬 발동기준 확률 
	public GameObject EventMessage;
	static bool open=false;


	// Use this for initialization
	void Start () {
		if( Random.Range(1, 100) <= iValue && !open) 
		{ 
			// 랜덤값이 지정한 iValue보다 작거나 같으면 if문 실행
			// 예) iValue 가 1(1%)이면 Random값이 1이 나올 때만 실행
			EventMessage.SetActive(true);
		} 

	}

	// Update is called once per frame
	void Update () {
		if(open) 
		{ 
			EventMessage.SetActive(false);
		} 
	
	}

	public void ChangeScene (string sceneToChangeTo)
	{
		Application.LoadLevel(sceneToChangeTo);
	}
}

