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

    public void MoveTo5()
    {
        ClickedTime_CamEv = 5;
        ChoicePanel.SetActive(false);
        DialogueBox.SetActive(true);
    }

    public void MoveTo7()
    {
        ClickedTime_CamEv = 7;
        ChoicePanel.SetActive(false);
        DialogueBox.SetActive(true);
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
                FadeIn(Cam_OnWall);
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
                Cam_OnWall.SetActive(true);
                Cam_Sorry.SetActive(false);
                DialogueText.text = "고마워...";
                FadeOut(Cam_OnWall);
                break;
            case 6:
                DialogueBox.SetActive(false);
                break;
            case 7:
                DialogueText.text = "그동안 고마웠어... 안녕...";
                break;
            case 8:
                Cam_Sorry.SetActive(false);
                DialogueText.text = "카멜레온은 조용히 방을 나갔다.";
                break;
            case 9:
                DialogueBox.SetActive(false);
                break;
            default:
                break;
        }
    }

    void FadeOut(GameObject Object)
    {
        Object.GetComponent<Image>().color = new Vector4(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, GetComponent<Image>().color.a + 0.02f);
    }

    void FadeIn(GameObject Object)
    {
        Object.GetComponent<Image>().color = new Vector4(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, GetComponent<Image>().color.a - 0.02f);
    }
}
