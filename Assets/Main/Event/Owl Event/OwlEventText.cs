using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OwlEventText : MonoBehaviour
{
    public Text text;
    public GameObject button;
    public GameObject Owl;
    public GameObject OwlForText;
    public GameObject Choice1;
    public GameObject Choice2;
    public GameObject ChicksImage;
    public GameObject[] ChickenForText;

    public static int ClickedTime_OwlEvent;

    void Start()
    {
        ClickedTime_OwlEvent = 0;
        ChicksImage.SetActive(false);
    }

    void Update()
    {
        switch (ClickedTime_OwlEvent)
        {
            case 0:
                button.SetActive(true);
                GetComponent<Text>().fontSize = 70;
                text.text = "선배~~";
                break;
            case 1:
                text.text = "저...조카들이 잠깐 놀러왔는데요....";
                break;
            case 2:
                text.text = "그...조카들이...저를 심하게 쫓아다녀서요...";
                break;
            case 3:
                text.text = "음...혹시...괜찮으시면 조카들 좀 선배 방에 데려와도 될까요?";
                break;
            case 4:
                text.text = "저도 염치없는 부탁이라는 걸 알지만...";
                break;
            case 5:
                text.text = "제가 선배 방에 놀러간다고 하니까 막 울면서 자기들도 따라가고 싶다고 해서...";
                break;
            case 6:
                OwlForText.GetComponent<Image>().enabled = false;
                Choice1.SetActive(true);
                button.SetActive(false);
                break;
            case 7:
                OwlForText.GetComponent<Image>().enabled = true;
                text.text = "음...그렇..죠...? 역시..좀..부담스러우시죠?";
                break;
            case 8:
                OwlForText.GetComponent<Image>().enabled = false;
                Choice2.SetActive(true);
                button.SetActive(false);
                break;
            case 9:
                text.text = "네...괜찮아요! 신경쓰지 마세요!";
                break;
            case 10:
                SceneManager.LoadScene("Main");
                break;
            case 11:
                OwlForText.GetComponent<Image>().enabled = true;
                text.text = "고마워요 선배!";
                break;
            case 12:
                text.text = "부담스러우실텐데...허락해주셔서 정말 감사해요.";
                break;
            case 13:
                text.text = "얘들아~ 여기 291호야. 들어와!";
                break;
            case 14:
                OwlForText.GetComponent<Image>().enabled = false;
                button.SetActive(false);
                ChicksImage.SetActive(true);
                break;
            case 15:
                OwlForText.GetComponent<Image>().enabled = true;
                text.text = "조카들이 좀 많죠...? 헤헤.";
                break;
            case 16:
                OwlForText.GetComponent<Image>().enabled = false;
                ChickenForText[0].GetComponent<SpriteRenderer>().enabled = true;
                text.text = "안녕하새오 병아리애오 놀러오게 해줘서 고마워오";
                break;
            case 17:
                ChickenForText[0].GetComponent<SpriteRenderer>().enabled = false;
                ChickenForText[1].GetComponent<SpriteRenderer>().enabled = true;
                text.text = "안녕하새오 부엉이 언니랑 하나도 안 달마따는 소리 많이 들어오 익숙해오";
                break;
            case 18:
                ChickenForText[1].GetComponent<SpriteRenderer>().enabled = false;
                ChickenForText[2].GetComponent<SpriteRenderer>().enabled = true;
                button.SetActive(false);
                break;
            case 19:
                ChickenForText[2].GetComponent<SpriteRenderer>().enabled = false;
                ChickenForText[3].GetComponent<SpriteRenderer>().enabled = true;
                button.SetActive(false);
                break;
            case 20:
                ChickenForText[3].GetComponent<SpriteRenderer>().enabled = false;
                ChickenForText[4].GetComponent<SpriteRenderer>().enabled = true;
                button.SetActive(false);
                break;
            case 21:
                text.text = "아, 실수...";
                break;
            case 22:
                button.SetActive(false);
                break;
            case 23:
                ChickenForText[4].GetComponent<SpriteRenderer>().enabled = false;
                ChickenForText[5].GetComponent<SpriteRenderer>().enabled = true;
                text.text = "zzzZZZ....zzz.....";
                break;
            case 24:
                ChickenForText[5].GetComponent<SpriteRenderer>().enabled = false;
                ChickenForText[6].GetComponent<SpriteRenderer>().enabled = true;
                button.SetActive(false);
                break;
            case 25:
                ChickenForText[6].GetComponent<SpriteRenderer>().enabled = false;
                ChickenForText[7].GetComponent<SpriteRenderer>().enabled = true;
                button.SetActive(false);
                break;
            case 26:
                ChickenForText[7].GetComponent<SpriteRenderer>().enabled = false;
                ChickenForText[8].GetComponent<SpriteRenderer>().enabled = true;
                text.text = "누나 이뻐오 이다음에 커서 누나랑 결혼하고시퍼오 ";
                break;
            case 27:
                SceneManager.LoadScene("Main");
                break;
            default:
                break;
        }
    }

    public void IsClicked()
    {
        ClickedTime_OwlEvent = ClickedTime_OwlEvent + 1;
    }
}
