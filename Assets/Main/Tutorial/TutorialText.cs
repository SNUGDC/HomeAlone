using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialText : MonoBehaviour
{
    public Text text;
    public GameObject button;
    public GameObject MenuButton;


    public static int ClickedTime = 0;

    void Update()
    {
        switch(ClickedTime)
        {
            case 0:
                button.SetActive(true);
                GetComponent<Text>().fontSize = 70;
                text.text = "291호 맞나요?";
                break;
            case 1:
                text.text = "안녕..! 나 카멜레온이야... 문 좀 열어줘...";
                break;
            case 2:
                text.text = "";
                break;
            case 3:
                text.text = "자취라니... 부럽네. 난 통학하는 데 3시간이 걸리는데도 허락 안 해주시던데...";
                break;
            case 4:
                text.text = "근데 구석에 먼지가 좀 쌓여있는 것 같아... 청소 좀 해야겠다... ";
                break;
            case 5:
                TutorialDustController.OrderNow = 1;
                button.SetActive(false);
                break;
            case 6:
                text.text = "채광도 좋고, 마트도 가까이 있고... 집 되게 잘 얻었구나...";
                break;
            case 7:
                MenuButton.SetActive(true);
//                MenuText.SetActive(true);
                button.SetActive(false);
                break;
            case 9:
                MenuButton.SetActive(false);
 //               MenuText.SetActive(false);
                text.text = "참... 오는 길에 딸기우유 사 왔어... 너 줄게...";
                break;
            case 10:
                text.text = "난 이만 가볼께... 다음에 또 놀러올게... 안녕...";
                break;
            case 11:
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
