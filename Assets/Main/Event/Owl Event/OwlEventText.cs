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

    public static int ClickedTime_OwlEvent;

    void Start()
    {
        ClickedTime_OwlEvent = 0;
        ChicksImage.SetActive(false);
    }

    void Update()
    {
        Debug.Log(ClickedTime_OwlEvent);
        switch (ClickedTime_OwlEvent)
        {
            case 0:
                button.SetActive(true);
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
            default:
                button.SetActive(false);
                OwlForText.SetActive(false);
                break;
        }
    }

    public void IsClicked()
    {
        ClickedTime_OwlEvent = ClickedTime_OwlEvent + 1;
    }
}
