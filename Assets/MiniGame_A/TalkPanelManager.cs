using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TalkPanelManager : MonoBehaviour
{
    public List<string> Text = new List<string>
    {
        "근데 선배님은 몇 학번이세요?",
        "너는 졸업 언제 해?",
        "요즘 SKY나와도 취직 잘 안 된대.",
        "선배는 군대 갔다 오신 거에요?",
        "엄마 친구 아들은 CPA 붙었다더라.",
        "너네 학교에 외무고시 최연소 합격생 있다며?",
        "아 이번에 학점이 4.2밖에 안 나왔어…",
        "장학금? 4.0 넘으면 되잖아?",
        "넌 의전원에는 관심없어?",
        "여자 직업으로 공무원만한 게 없지.",
        "그만큼 휴학했으면 대외활동 많이 했겠다."
    };

    public Text text;

    void Start ()
    {
        text.text = Text[Random.Range(0, 10)];
	}

}
