using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RealEndingDialogueText : MonoBehaviour
{
    public Text DialogueText;
    public GameObject DialogueBox;
    public GameObject SelfReproachPanel;
    public GameObject Player_ReadingLetter;
    public GameObject Player_Behind;

    int ClickedTime_RealEnd;

    public void ClickedButton()
    {
        ClickedTime_RealEnd += 1;
    }

    void Start()
    {
        SelfReproachPanel.SetActive(false);
        ClickedTime_RealEnd = 0;
    }

    void Update()
    {
        switch(ClickedTime_RealEnd)
        {
            case 0:
                DialogueText.text = "\"..저희...인형 전문...토이몰을 이용해주신...고객님께 감사드립니다..";
                break;
            case 1:
                DialogueText.text = "고객님의 멤버십 등급은 골드이며... 할인 쿠폰을 동봉해드리오니...";
                break;
            case 2:
                DialogueText.text = "앞으로도 많은 사랑 부탁드립니다.\"";
                break;
            case 3:
                DialogueText.text = "...";
                break;
            case 4:
                DialogueText.text = ".........";
                Destroy(Player_ReadingLetter);
                Player_Behind.SetActive(true);
                break;
            case 5:
                SelfReproachPanel.SetActive(true);
                DialogueBox.SetActive(false);
                break;
            case 6:
                DialogueText.text = "";
                break;
            case 7:
                DialogueText.text = "";
                break;
            default:
                break;
        }
    }
}
