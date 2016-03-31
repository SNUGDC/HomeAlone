using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PenguinEventText : MonoBehaviour
{
    public Text text;
    public GameObject button;
    public GameObject UI_ToiletEvent;
    public GameObject Penguin;
    public GameObject PenguinForText;

    public static int ClickedTime_PenguinEvent;

    void Start()
    {
        ClickedTime_PenguinEvent = 0;
    }

    void Update()
    {
        switch (ClickedTime_PenguinEvent)
        {
            case 0:
                button.SetActive(true);
                text.text = "우왕! 이게 뭐야? 색깔 예쁘다.";
                break;
            case 1:
                text.text = "형제...소다? 신제품인가보다. 처음 봐. 맛있어보여!";
                break;
            case 2:
                text.text = "모두 건배~ 짠~!";
                break;
            case 3:
                button.SetActive(false);
                break;
            case 4:
                text.text = "에...맛있땅...";
                break;
            case 5:
                text.text = "아 오빠ㅅ(삐이이이익-) 나가 (삐이이이익-)으면 좋겠다~!";
                break;
            case 6:
                text.text = "우웅...나...화장실 좀 써도 되지?";
                break;
            case 7:
                button.SetActive(false);
                Penguin.GetComponent<SpriteRenderer>().enabled = false;
                PenguinForText.GetComponent<SpriteRenderer>().enabled = false;
                break;
            case 8:
                text.text = "(펭귄이 10분째 화장실에서 나오지 않는다.)";
                break;
            case 9:
                text.text = "(화장실에 귀를 대 보았지만, 정적만이 감돌 뿐이었다.)";
                break;
            case 10:
                text.text = "(펭귄의 상태가 좋지 않은 것 같다.)";
                break;
            case 11:
                button.SetActive(false);
                UI_ToiletEvent.SetActive(true);
                break;
            default:
                break;
        }

        if(ToiletDoorTap.IsSuccess)
        {
            switch(ClickedTime_PenguinEvent)
            {
                case 12:
                    UI_ToiletEvent.SetActive(false);
                    Penguin.GetComponent<SpriteRenderer>().enabled = true;
                    PenguinForText.GetComponent<SpriteRenderer>().enabled = true;
                    text.text = "으음....아! 미안해, 미안해....";
                    break;
                case 13:
                    text.text = "너무 노곤노곤해져서 깜박 졸았나봐. 미안...";
                    break;
                case 14:
                    text.text = "나 혹시 실수한 거 없지? 혹시 나 이상한 소리했니?";
                    break;
                case 15:
                    text.text = "그래? 다행이다. 미안해 걱정시켜서...";
                    break;
                case 16:
                    text.text = "(펭귄은 부끄러워하며 웃었다.)";
                    break;
                case 17:
                    SceneManager.LoadScene("Main");
                    break;
                default:
                    break;
            }
        }
        else if(ToiletDoorTap.IsSuccess == false)
        {
            switch (ClickedTime_PenguinEvent)
            {
                case 12:
                    UI_ToiletEvent.SetActive(false);
                    text.text = "....";
                    break;
                case 13:
                    button.SetActive(false);
                    break;
                case 14:
                    text.text = "...zzZZZ....";
                    break;
                case 15:
                    button.SetActive(false);
                    break;
                case 16:
                    text.text = "...zzzZZZ....zzz......zzzZZZ.....";
                    break;
                case 17:
                    text.text = "(펭귄이 화장실 안에서 문을 잠근 채 잠들어버렸다.)";
                    break;
                case 18:
                    text.text = "(그렇게 밤새도록 화장실을 사용할 수 없었다...)";
                    break;
                case 19:
                    SceneManager.LoadScene("Main");
                    break;
                default:
                    break;
            }
        }
    }

    public void IsClicked()
    {
        ClickedTime_PenguinEvent = ClickedTime_PenguinEvent + 1;
    }
}
