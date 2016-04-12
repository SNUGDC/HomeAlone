using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToEpisode : MonoBehaviour {
	public GameObject DialogPanel, sheepChat, crocodileChat, owlChat, lionChat, ammoniteChat, bearChat, snakeChat, bear;
	private bool BearEventShow, sheepEpShow, crocoEpShow, owlEpShow, lionEpShow, ammoEpShow, snakeEpShow, bearEpShow, OwnerEventShow;
	private int month, day, AmmoMonth, AmmoDay;
	void Start () {
		BearEventShow = (PlayerPrefs.GetString ("BearEvent") == "True");
		sheepEpShow = (PlayerPrefs.GetString ("sheepEpShow") == "True");
		crocoEpShow = (PlayerPrefs.GetString ("crocoEpShow") == "True");
		owlEpShow = (PlayerPrefs.GetString ("owlEpShow") == "True");
		lionEpShow = (PlayerPrefs.GetString ("lionEpShow") == "True");
		ammoEpShow = (PlayerPrefs.GetString ("ammoEpShow") == "True");
		snakeEpShow = (PlayerPrefs.GetString ("snakeEpShow") == "True");
		bearEpShow = (PlayerPrefs.GetString ("bearEpShow") == "True");
		OwnerEventShow = (PlayerPrefs.GetString ("OwnerEventShow") == "True");

		month = PlayerPrefs.GetInt ("Month");
		day = PlayerPrefs.GetInt ("Day");
		if (PlayerPrefs.HasKey ("AmmoMonth")) {
			AmmoMonth = PlayerPrefs.GetInt ("AmmoMonth");
			AmmoDay = PlayerPrefs.GetInt ("AmmoDay");
			//Owner Event
			if (((month > AmmoMonth) || ((month == AmmoMonth) && (day >= (AmmoDay + 7)))) && !OwnerEventShow) {
				OwnerEventShow = true;
				SceneManager.LoadScene ("Owner Event");
				PlayerPrefs.SetString ("OwnerEventShow", OwnerEventShow.ToString ());
			}
		}
	}
	
	// Update is called once per frame
	void Update () {			
		if (!DialogPanel.activeSelf) {
			if ((bear.GetComponent<VisitFriend> ().VisitNumber >= 45) && !BearEventShow) {
				BearEventShow = true;
				SceneManager.LoadScene ("Bear Event");
				PlayerPrefs.SetString ("BearEvent", BearEventShow.ToString ());
			} else if ((sheepChat.GetComponent<TalkBalloon> ().NumberOfTalk () == 20) && !sheepEpShow) {
				SceneManager.LoadScene ("SheepEp");
				sheepEpShow = true;
				PlayerPrefs.SetString ("sheepEpShow", sheepEpShow.ToString ());
			} else if ((crocodileChat.GetComponent<TalkBalloon> ().NumberOfTalk () == 20) && !crocoEpShow) {
				SceneManager.LoadScene ("CrocodileEp");
				crocoEpShow = true;
				PlayerPrefs.SetString ("crocoEpShow", crocoEpShow.ToString ());
			} else if ((owlChat.GetComponent<TalkBalloon> ().NumberOfTalk () == 20) && !owlEpShow) {
				SceneManager.LoadScene ("OwlEp");
				owlEpShow = true;
				PlayerPrefs.SetString ("owlEpShow", owlEpShow.ToString ());
			} else if ((lionChat.GetComponent<TalkBalloon> ().NumberOfTalk () == 20) && !lionEpShow) {
				SceneManager.LoadScene ("LionEp");
				// lionEpShow = true;
				// PlayerPrefs.SetString ("lionEpShow",lionEpShow.ToString());
				// save: in episode
			} else if ((ammoniteChat.GetComponent<TalkBalloon> ().NumberOfTalk () == 20) && !ammoEpShow) {
				SceneManager.LoadScene ("AmmoniteEp");
				ammoEpShow = true;
				PlayerPrefs.SetString ("ammoEpShow", ammoEpShow.ToString ());
			} else if ((bearChat.GetComponent<TalkBalloon> ().NumberOfTalk () == 20) && !bearEpShow) {
				SceneManager.LoadScene ("BearEp");
				// bearEpShow = true;
				// PlayerPrefs.SetString ("bearEpShow",bearEpShow.ToString());
				// save: in episode
			} else if ((snakeChat.GetComponent<TalkBalloon> ().NumberOfTalk () == 20) && !snakeEpShow) {
				SceneManager.LoadScene ("SnakeEp");
				// snakeEpShow = true;
				// PlayerPrefs.SetString ("snakeEpShow",snakeEpShow.ToString());
				// save: in episode
			}
		}
	}
}
