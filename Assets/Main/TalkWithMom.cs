using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TalkWithMom : MonoBehaviour
{
    public GameObject MomImage;
    public GameObject MomPanel;

    public bool ReadyToChangeText;
    public int WillMomTalk;
    public int CurrentLine = 0;

    string[] talkline = { "우리 딸, 방에는 도착했니? 우리 딸은 알아서 잘 하겠지만 그래도 걱정되네.",
                          "옆에서 챙겨줄 사람이 없으니까 일정관리를 잘해야해. 그렇다고 너무 공부만 하진 말구",
                          "집안일은 매일 해둬야 귀찮지 않단다. 참, 생활비는 매월 1일에 보내줄께",
                          "그럼 다음에 또 통화하자. 사랑해~",
                          ""};

    [SerializeField]
    private Text value = null;

    void Start()
    {
        WillMomTalk = PlayerPrefs.GetInt("WillMomTalk");
        WillMomTalk = 1;
    }

    void Update()
    {
        if (WillMomTalk == 1)
        {
            TalkAble(true);
        }
        ReadyToChangeText = MomPanel.GetComponent<ReadyToChangeText>().IsOKToChangeText;

        if (CurrentLine > 4)
        {
            WillMomTalk = 0;
            TalkAble(false);
        }

        if (ReadyToChangeText)
        {
            ChangeText(CurrentLine);
        }
    }

    void ChangeText(int CurrentLine)
    {
        value.text = talkline[CurrentLine];
        MomPanel.GetComponent<ReadyToChangeText>().IsOKToChangeText = false;
        this.CurrentLine++;
    }

    void TalkAble(bool a)
    {
            MomImage.GetComponent<SpriteRenderer>().enabled = a;
            MomPanel.GetComponent<SpriteRenderer>().enabled = a;
            MomPanel.GetComponent<BoxCollider2D>().enabled = a;
    }

    void save()
    {
        PlayerPrefs.SetInt("WillMomTalk", WillMomTalk);
    }
}
