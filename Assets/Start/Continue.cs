using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public GameObject CannotContinuePanel;

    void Start()
    {
        CannotContinuePanel.SetActive(false);
        if(IsEnding())
            PlayerPrefs.SetString("IsEnding", "True");
    }

    public void TransferToMain()
    {
        if (PlayerPrefs.HasKey("Is Tutorial Finish"))
        {
			if (PlayerPrefs.GetInt ("SeeRealEnding") == 1 || PlayerPrefs.GetInt ("SeeRealEnding") == 2) {
				// After real Ending + developer event
				if (PlayerPrefs.GetString("DeveloperShow") == "True")
					SceneManager.LoadScene ("AfterRealEnding");
				else if((PlayerPrefs.GetString("SeeAfterReadlEnding") == "True"))
					SceneManager.LoadScene ("Developer Event");
				else SceneManager.LoadScene ("AfterRealEnding");
			}
            else
            {
				// Developer event of Happy Ending
				if ((PlayerPrefs.GetString("WhatIsEnd") == "HappyEnding") && !(PlayerPrefs.GetString("DeveloperShow") == "True"))
					SceneManager.LoadScene ("Developer Event");
				
				//Ending!
				else if (IsEnding()) {
					int NumberOfNegativeChoice = PlayerPrefs.GetInt ("NumberOfNegativeChoice");
					bool SnakeAnswer = (PlayerPrefs.GetString("SnakeAnswer") != "False");
                    //Happy Ending
                    if (SnakeAnswer || (NumberOfNegativeChoice < 2))
                    {
                        SceneManager.LoadScene("Main");
                        PlayerPrefs.SetString("WhatIsEnd", "HappyEnding");
                    }
                    //Real Ending
                    else
                    {
                        SceneManager.LoadScene("Main");
                        PlayerPrefs.SetString("WhatIsEnd", "RealEnding");
                    }
				}

                else if (PlayerPrefs.HasKey("HowMuchTimePass") && PlayerPrefs.GetInt("HowMuchTimePass") <= 10)
                    SceneManager.LoadScene("Owl Event");
                else
                    SceneManager.LoadScene("Main");
            }
        }
        else CannotContinuePanel.SetActive(true);
    }

	private bool IsEnding(){
		bool PenguinEpShow, sheepEpShow, crocoEpShow, owlEpShow, lionEpShow, ammoEpShow, snakeEpShow, bearEpShow;

		PenguinEpShow = PlayerPrefs.HasKey ("MiniPhotoOn");
		sheepEpShow = (PlayerPrefs.GetString ("sheepEpShow") == "True");
		crocoEpShow = (PlayerPrefs.GetString ("crocoEpShow") == "True");
		owlEpShow = (PlayerPrefs.GetString ("owlEpShow") == "True");
		lionEpShow = (PlayerPrefs.GetString ("lionEpShow") == "True");
		ammoEpShow = (PlayerPrefs.GetString ("ammoEpShow") == "True");
		snakeEpShow = (PlayerPrefs.GetString ("snakeEpShow") == "True");
		bearEpShow = (PlayerPrefs.GetString ("bearEpShow") == "True");

		return PenguinEpShow && sheepEpShow && crocoEpShow && owlEpShow && lionEpShow && ammoEpShow && snakeEpShow && bearEpShow;
	}
}