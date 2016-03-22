using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RealEndingDialogueText : MonoBehaviour
{
    public Text DialogueText;

    int ClickedTime_RealEnd;

    public void ClickedButton()
    {
        ClickedTime_RealEnd += 1;
    }

    void Update()
    {
        switch(ClickedTime_RealEnd)
        {
            case 0:
                DialogueText.text = "...저희...인형 전문...토이몰을 이용해주신...고객님께 감사드립니다..";
                break;
            case 1:
                DialogueText.text = "고객님의 멤버십 등급은 골드이며... 할인 쿠폰을 동봉해드리오니...";
                break;
            case 2:
                DialogueText.text = "앞으로도 많은 사랑 부탁드립니다.";
                break;
            default:
                break;
        }
    }
}
