using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class SelfReproachText : MonoBehaviour
{
    public GameObject Text;
    public GameObject RealEndingPicture;

    int Stage;
    int TextStage;
    bool IsRecord;
    bool FadeOutFinish;
    bool FadeInFinish;
    DateTime StartTime;
    DateTime NowTime;

    void Start()
    {
        GetComponent<Image>().color = new Vector4(0, 0, 0, -1);
        Text.GetComponent<Text>().color = new Vector4(1, 1, 1, 0);
        RealEndingPicture.GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, 0);
        RealEndingPicture.SetActive(false);
        FadeOutFinish = false;
        FadeInFinish = false;
        TextStage = 0;
    }

    void Update()
    {
        Text.GetComponent<Text>().color = new Vector4(1, 1, 1, GetComponent<Image>().color.a);
        switch(TextStage)
        {
            case 0:
                ShowText();
                break;
            case 1:
                Text.GetComponent<Text>().text = "성적이 높다는 이유로 따돌림당했다.";
                ShowText();
                break;
            case 2:
                Text.GetComponent<Text>().text = "남자애들과 어울린다는 이유로 소외당했다.";
                ShowText();
                break;
            case 3:
                Text.GetComponent<Text>().text = "차가웠던 날의 감촉";
                ShowText();
                break;
            case 4:
                Text.GetComponent<Text>().text = "사랑하는 사람으로부터 버림받았다.";
                ShowText();
                break;
            case 5:
                Text.GetComponent<Text>().text = "의미없는 휴학, 늦은 졸업";
                ShowText();
                break;
            case 6:
                Text.GetComponent<Text>().text = "열등감 덩어리, 부모님의 실패작";
                ShowText();
                break;
            case 7:
                Text.GetComponent<Text>().text = "나잖아, 전부.";
                
                ShowText();
                break;
            case 8:
                RealEndingPicture.SetActive(true);
                RealEndingPicture.GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, RealEndingPicture.GetComponent<SpriteRenderer>().color.a + 0.02f);
                break;
            default:
                break;
        }
    }

    void FadeOut()
    {
        GetComponent<Image>().color = new Vector4(0, 0, 0, GetComponent<Image>().color.a + 0.02f);
    }

    void FadeIn()
    {
        GetComponent<Image>().color = new Vector4(0, 0, 0, GetComponent<Image>().color.a - 0.02f);
    }

    void ShowText()
    {
        if (GetComponent<Image>().color.a > 2)
            FadeOutFinish = true;
        else if (GetComponent<Image>().color.a < -2)
            FadeInFinish = true;

        if (FadeOutFinish)
        {
            if (FadeInFinish)
            {
                TextStage += 1;
                FadeInFinish = false;
                FadeOutFinish = false;
                GetComponent<Image>().color = new Vector4(0, 0, 0, 0);
                return;
            }
            else FadeIn();
        }
        else FadeOut();
    }
}
