using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameleonDialogueText : MonoBehaviour
{
    public Text DialogueText;
    public GameObject DialogueBox;
    public GameObject ChoicePanel;
    public GameObject Cam_OnWall;
    public GameObject Cam_Sorry;

    int ClickedTime_CamEv;

    public void ClickedButton()
    {
        ClickedTime_CamEv += 1;
    }

    void Start()
    {
        Cam_Sorry.SetActive(false);
        ChoicePanel.SetActive(false);
    }

    void Update()
    {
        switch(ClickedTime_CamEv)
        {
            case 0:
                DialogueText.text = "앗... 들켰다...";
                break;
            case 1:
                Cam_OnWall.SetActive(false);
                Cam_Sorry.SetActive(true);
                DialogueText.text = "미안해... 학교랑 집이랑 너무 멀어서...";
                break;
            case 2:
                DialogueText.text = "며칠만 신세진다는 게...";
                break;
            case 3:
                DialogueText.text = "좀 더 지내게 해주면 안 되겠니...?";
                break;
            case 4:
                ChoicePanel.SetActive(true);
                DialogueBox.SetActive(false);
                break;
            case 5:
                DialogueText.text = "고마워...";
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                break;
            case 11:
                break;
            default:
                break;
        }
    }
}
