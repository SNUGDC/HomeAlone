using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TalkWithMom : MonoBehaviour
{
    public GameObject MomImage;
    public GameObject PanelCollider;
    public Image MomPanel;

    private bool ReadyToChangeText;
    private bool WillMomTalk = true;
    private int CurrentLine = 0;

    string[] talkline = { "우리 딸, 방에는 도착했니? 우리 딸은 알아서 잘 하겠지만 그래도 걱정되네.",
                          "옆에서 챙겨줄 사람이 없으니까 일정관리를 잘해야해. 그렇다고 너무 공부만 하진 말구",
                          "집안일은 매일 해둬야 귀찮지 않단다. 참, 생활비는 매월 1일에 보내줄께",
                          "그럼 다음에 또 통화하자. 사랑해~",
                          ""};

    [SerializeField]
    private Text value = null;

    void Start()
    {
        if (WillMomTalk)
        {
            MomImage.GetComponent<SpriteRenderer>().enabled = true;
            PanelCollider.GetComponent<BoxCollider>().enabled = true;
            MomPanel.enabled = true;
        }
    }

    void Update()
    {
        ReadyToChangeText = PanelCollider.GetComponent<ReadyToChangeText>().IsOKToChangeText;

        if (CurrentLine > 4)
        {
            WillMomTalk = false;
            MomImage.GetComponent<SpriteRenderer>().enabled = false;
            PanelCollider.GetComponent<BoxCollider>().enabled = false;
            MomPanel.enabled = false;
        }

        if (ReadyToChangeText)
        {
            ChangeText(CurrentLine);
        }
    }

    void ChangeText(int CurrentLine)
    {
        value.text = talkline[CurrentLine];
        PanelCollider.GetComponent<ReadyToChangeText>().IsOKToChangeText = false;
        this.CurrentLine++;
    }
}
