using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveToCamEvent : MonoBehaviour
{
	public Text TalkPanelText;
    public void MoveToEvent()
    {
		PlayerPrefs.SetString ("CameleonEventShow","True");
        SceneManager.LoadScene("Cameleon Event");
    }

	public void ChangeText(){
		bool CameleonAnswer = (PlayerPrefs.GetString ("CameleonAnswer") == "True");

		//say yes
		if(CameleonAnswer){
			TalkPanelText.text = "고마워...";
		}

		//say no
		else{
			TalkPanelText.text = "그동안 고마웠어... 안녕...";
		}
			
	}
}
