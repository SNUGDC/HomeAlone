using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialText : MonoBehaviour
{
    public Text text;
    public GameObject button;
    public GameObject MenuButton;
    public GameObject TapToProgress;


    public static int ClickedTime = 0;

    void Update()
    {
        switch(ClickedTime)
        {
            case 0:
                button.SetActive(true);
                text.text = "291호 맞나요?";
                break;
            case 1:
                text.text = "안녕..! 나 카멜레온이야... 문 좀 열어줘...";
                break;
            case 2:
                text.text = "";
                break;
            case 4:
                TapToProgress.SetActive(false);
                text.text = "자취라니... 부럽네. 난 통학하는 데 3시간이 걸리는데도 허락 안 해주시던데...";
                break;
            case 5:
                text.text = "채광도 좋고, 마트도 가까이 있고... 집 되게 잘 얻었구나...";
                break;
            case 6:
                TutorialDustController_Click.OrderNow = 1;
                button.SetActive(false);
                break;
            case 7:
                text.text = "(스와이프해서 청소할 수도 있어요.)";
                break;
            case 8:
                button.SetActive(false);
                break;
            case 9:
                button.SetActive(false);
                break;
            case 10:
                text.text = "(메뉴창 바깥을 터치하면 방 화면으로 나갈 수 있어요.)";
                TapToProgress.SetActive(true);
                break;
            case 11:
                TapToProgress.SetActive(false);
                MenuButton.SetActive(false);
                text.text = "(참, 친구들이 너무 오랫동안 방을 떠나지 않는 것 같다면, 최후의 수단으로 소화기를 사용하세요!)";
                break;
            case 12:
                PlayerPrefs.SetString("Is Tutorial Finish", "Yes");
                SceneManager.LoadScene("Main");
                break;
            default:
                button.SetActive(false);
                break;
        }
    }

    public void IsClicked()
    {
        ClickedTime = ClickedTime + 1;
    }
}
