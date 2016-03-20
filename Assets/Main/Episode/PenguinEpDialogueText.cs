using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PenguinEpDialogueText : MonoBehaviour
{
    public GameObject DialogueBox;
    public GameObject ChoicePanel;
    public GameObject FadeOut;
    public GameObject Photo;
    public GameObject Room;
    public Text DialogueText;

    static int ClickedTime_PenguinEp;
    static bool IsNeutralChoice_PenguinEp;
    int NumberOfNegativeChoice;
    Color FadeOutPanelColor;

    void Start()
    {
        ClickedTime_PenguinEp = 0;
        DialogueBox.SetActive(true);
        FadeOut.SetActive(false);
        ChoicePanel.SetActive(false);
        Photo.SetActive(false);
        Room.SetActive(true);  
    }

    public void ClickedButton()
    {
        ClickedTime_PenguinEp += 1;
    }

    void Update()
    {
        FadeOutPanelColor = FadeOut.GetComponent<Image>().color;

        switch (ClickedTime_PenguinEp)
        {
            case 0:
                DialogueText.text = "음, 나, 있지, 궁금한 게 있어!";
                break;
            case 1:
                DialogueText.text = "왜 네 방에는 사진이나 액자같은 게 아무것도 없어?";
                break;
            case 2:
                DialogueBox.SetActive(false);
                ChoicePanel.SetActive(true);
                break;
            case 3:
                if(IsNeutralChoice_PenguinEp)
                    DialogueText.text = "그치? 역시 약간 허전하지 않아?";
                else
                    DialogueText.text = "아...그래...? 사진같은 거 별로 안 좋아하나보다. 음...";
                break;
            case 4:
                DialogueText.text = "어... 우리 같이 스티커사진 찍으러가지 않을래...?";
                break;
            case 5:
                DialogueText.text = "맨날 오빠가 못생기고 뚱뚱하다고 구박하고...";
                break;
            case 6:
                DialogueText.text = "주변 사람들도 매번 내 몸매를 비웃는 것 같아서 우울했었는데...";
                break;
            case 7:
                DialogueText.text = "매번 집에 초대해주고 이야기도 들어주고...이런 말 하면 조금 낯간지럽지만...";
                break;
            case 8:
                DialogueText.text = "네 덕분에 자신감이 조금 생긴 것 같아. 그래서 네가 정말 좋고...또 고마워.";
                break;
            case 9:
                DialogueText.text = "전에는 셀카를 찍으려고 해도 내 자신이 너무 못생겨보여서 찍을 수가 없었어.";
                break;
            case 10:
                DialogueText.text = "그치만 이젠 괜찮을 거 같아. 아, 내가 이뻐졌다는 뜻은 아니고! 킁.큼흠.";
                break;
            case 11:
                DialogueText.text = "그리구... 다른 여자애들 보면 친한 애들끼리 스티커 사진...많이들 찍잖아.";
                break;
            case 12:
                DialogueText.text = "우리도...친..하니까!";
                break;
            case 13:
                DialogueText.text = "스티커 사진 찍어서 다이어리에도 붙이고...지갑에도 넣어다니고...그러고 싶어.";
                break;
            case 14:
                DialogueText.text = "시내에 스티커사진 찍는 곳 있는데. 같이 가지 않을래?";
                break;
            case 15:
                FadeOut.SetActive(true);
                FadeOut.GetComponent<Image>().color = new Vector4(0, 0, 0, FadeOutPanelColor.a + 0.01f);
                if(FadeOutPanelColor.a >1.0f)
                    ClickedTime_PenguinEp = 16;
                break;
            case 16:
                FadeOut.GetComponent<Image>().color = new Vector4(FadeOutPanelColor.r + 0.01f, FadeOutPanelColor.g + 0.01f, FadeOutPanelColor.b + 0.01f, 1);
                if (FadeOutPanelColor.r > 1.0f)
                    ClickedTime_PenguinEp = 17;
                break;
            case 17:
                Photo.SetActive(true);
                Room.SetActive(false);
                DialogueText.text = "(스티커 사진을 찍었다.)";
                FadeOut.GetComponent<Image>().color = new Vector4(1, 1, 1, FadeOutPanelColor.a - 0.02f);
                if (FadeOutPanelColor.a < 0f)
                    ClickedTime_PenguinEp = 18;
                break;
            case 18:
                FadeOut.SetActive(false);
                break;
            case 19:
                DialogueText.text = "(오랜만에 찍는 사진이라서 어색했다. )";
                PlayerPrefs.SetInt("MiniPhotoOn", 1);
                break;
            case 20:
                Photo.GetComponent<Collider2D>().enabled = true;
                DialogueBox.SetActive(false);
                break;
            default:
                DialogueBox.SetActive(false);
                break;
        }
    }

    public void ChooseNegativeChoice()
    {
        if (PlayerPrefs.HasKey("NumberOfNegativeChoice"))
        {
            NumberOfNegativeChoice = PlayerPrefs.GetInt("NumberOfNegativeChoice");
            NumberOfNegativeChoice += 1;
            PlayerPrefs.SetInt("NumberOfNegativeChoice", NumberOfNegativeChoice);
        }
        else PlayerPrefs.SetInt("NumberOfNegativeChoice", 1);

        DialogueBox.SetActive(true);
        ChoicePanel.SetActive(false);
        ClickedTime_PenguinEp = 3;
    }

    public void ChooseNeutralChoice()
    {
        DialogueBox.SetActive(true);
        ChoicePanel.SetActive(false);
        ClickedTime_PenguinEp = 3;
    }
}
