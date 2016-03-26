using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToEpisode : MonoBehaviour {
	public GameObject sheepChat, crocodileChat, owlChat, lionChat, ammoniteChat, bearChat, snakeChat, bear;
	private bool BearEventShow, sheepEpShow, crocoEpShow, owlEpShow, lionEpShow, ammoEpShow, snakeEpShow, bearEpShow;

	void Start () {
		BearEventShow = (PlayerPrefs.GetString ("BearEvent") == "True");
		sheepEpShow = (PlayerPrefs.GetString ("sheepEpShow") == "True");
		crocoEpShow = (PlayerPrefs.GetString ("crocoEpShow") == "True");
		owlEpShow = (PlayerPrefs.GetString ("owlEpShow") == "True");
		lionEpShow = (PlayerPrefs.GetString ("lionEpShow") == "True");
		ammoEpShow = (PlayerPrefs.GetString ("ammoEpShow") == "True");
		snakeEpShow = (PlayerPrefs.GetString ("snakeEpShow") == "True");
		bearEpShow = (PlayerPrefs.GetString ("bearEpShow") == "True");
	}
	
	// Update is called once per frame
	void Update () {
		if ((bear.GetComponent<VisitFriend>().VisitNumber >= 40) && !BearEventShow) {
			BearEventShow = true;
			SceneManager.LoadScene ("Bear Event");
			PlayerPrefs.SetString ("BearEvent",BearEventShow.ToString());
		}

		else if ((sheepChat.GetComponent<TalkBalloon> ().NumberOfTalk() == 20) && !sheepEpShow) {
			SceneManager.LoadScene ("SheepEp");
			sheepEpShow = true;
			PlayerPrefs.SetString ("sheepEpShow",sheepEpShow.ToString());
		}

		else if ((crocodileChat.GetComponent<TalkBalloon> ().NumberOfTalk() == 20) && !crocoEpShow) {
			SceneManager.LoadScene ("CrocodileEp");
			crocoEpShow = true;
			PlayerPrefs.SetString ("crocoEpShow",crocoEpShow.ToString());
		}

		else if ((owlChat.GetComponent<TalkBalloon> ().NumberOfTalk() == 20) && !owlEpShow) {
			SceneManager.LoadScene ("OwlEp");
			owlEpShow = true;
			PlayerPrefs.SetString ("owlEpShow",owlEpShow.ToString());
		}

		else if ((lionChat.GetComponent<TalkBalloon> ().NumberOfTalk() == 20) && !lionEpShow) {
			SceneManager.LoadScene ("LionEp");
			// lionEpShow = true;
			// PlayerPrefs.SetString ("lionEpShow",lionEpShow.ToString());
			// save: in episode
		}

		else if ((ammoniteChat.GetComponent<TalkBalloon> ().NumberOfTalk() == 20) && !ammoEpShow) {
			SceneManager.LoadScene ("AmmoniteEp");
			ammoEpShow = true;
			PlayerPrefs.SetString ("ammoEpShow",ammoEpShow.ToString());
		}

		else if ((bearChat.GetComponent<TalkBalloon> ().NumberOfTalk() == 20) && !bearEpShow) {
			SceneManager.LoadScene ("BearEp");
			// bearEpShow = true;
			// PlayerPrefs.SetString ("bearEpShow",bearEpShow.ToString());
			// save: in episode
		}

		else if ((snakeChat.GetComponent<TalkBalloon> ().NumberOfTalk() == 20) && !snakeEpShow) {
			SceneManager.LoadScene ("SnakeEp");
			// snakeEpShow = true;
			// PlayerPrefs.SetString ("snakeEpShow",snakeEpShow.ToString());
			// save: in episode
		}
	}
}
