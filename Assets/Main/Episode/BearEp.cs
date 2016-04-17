using UnityEngine;
using System.Collections;

public class BearEp : MonoBehaviour
{
    public GameObject dialogwindow, dialog, choose, YesDialog, NoDialog, nodia, player, playernorm, playersad;
    public string IsAlreadyShowSaveName, AnswerSaveName;
    private bool IsAlreadyShow, SaveAnswer;

    // Use this for initialization
    void Start()
    {
        IsAlreadyShow = (PlayerPrefs.GetString(IsAlreadyShowSaveName) == "True");
        SaveAnswer = (PlayerPrefs.GetString(AnswerSaveName) == "True");
        PlayerPrefs.SetString(IsAlreadyShowSaveName, "True");
        Debug.Log("Save Answer : " + SaveAnswer);
    }

    // Update is called once per frame
    void Update()
    {
        CheckState();
    }

    public void OpenChoose(int line)
    {
        if (dialog.GetComponent<Dialog>().LineNumber == line)
        {
            if (!IsAlreadyShow)
            {
                choose.SetActive(true);
                dialogwindow.SetActive(false);
            }

            // Already Show
            else
            {
                // answer "yes"
                if (SaveAnswer)
                {
                    YesDialog.SetActive(true);
                    dialogwindow.SetActive(false);
                }

                // answer "no"
                else
                {
                    NoDialog.SetActive(true);
                    dialogwindow.SetActive(false);
                }
            }
        }
    }

    public void CheckState()
    {
        if (nodia.GetComponent<Dialog>().LineNumber == 1)
        {
            player.SetActive(false);
            playernorm.SetActive(true);
        }
        else if (nodia.GetComponent<Dialog>().LineNumber == 5)
        {
            playernorm.SetActive(false);
            playersad.SetActive(true);
        }
    }
}

