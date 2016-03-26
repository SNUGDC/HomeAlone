using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class SelfReproachText : MonoBehaviour
{
    public GameObject Text;
    public GameObject RealEndingPicture;

    public GameObject Penguin;
    public GameObject Owl;
    public GameObject Lion;
    public GameObject Bear;
    public GameObject SheepAndCroc;
    public GameObject Ammo;
    public GameObject Snake;
    public GameObject EndingSound;

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
                ShowText(Penguin);
                break;
            case 1:
                Text.GetComponent<Text>().text = "성적이 높다는 이유로 따돌림당했다.";
                ShowText(Owl);
                break;
            case 2:
                Text.GetComponent<Text>().text = "남자애들과 어울린다는 이유로 소외당했다.";
                ShowText(Lion);
                break;
            case 3:
                Text.GetComponent<Text>().text = "차가웠던 날의 감촉";
                ShowText(Bear);
                break;
            case 4:
                Text.GetComponent<Text>().text = "사랑하는 사람으로부터 버림받았다.";
                ShowText(SheepAndCroc);
                break;
            case 5:
                Text.GetComponent<Text>().text = "의미없는 휴학, 늦은 졸업";
                ShowText(Ammo);
                break;
            case 6:
                GetComponent<Image>().color = new Vector4(1, 1, 1, GetComponent<Image>().color.a);
                Text.GetComponent<Text>().text = "열등감 덩어리, 부모님의 실패작";
                ShowText(Snake);
                break;
            case 7:
                GetComponent<Image>().color = new Vector4(0, 0, 0, GetComponent<Image>().color.a);
                Text.GetComponent<Text>().text = "나잖아, 전부.";
                ShowText(Snake);
                break;
            case 8:
                RealEndingPicture.SetActive(true);
                RealEndingPicture.GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, RealEndingPicture.GetComponent<SpriteRenderer>().color.a + 0.02f);
                if (RealEndingPicture.GetComponent<SpriteRenderer>().color.a > 4)
                    TextStage = 9;
                break;
            case 9:
                Text.GetComponent<Text>().text = "Home Alone";
                Text.GetComponent<Text>().fontSize = 80;
                FadeOut();
                EndingSound.SetActive(true);
                PlayerPrefs.SetInt("SeeRealEnding", 1);
                break;
            default:
                break;
        }
    }

    void FadeOut()
    {
        GetComponent<Image>().color = new Vector4(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, GetComponent<Image>().color.a + 0.02f);
    }

    void FadeIn()
    {
        GetComponent<Image>().color = new Vector4(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, GetComponent<Image>().color.a - 0.02f);
    }

    void ShowText(GameObject Object)
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
            else
            {
                Object.SetActive(true);
                FadeIn();
            }
        }
        else FadeOut();
    }
}
