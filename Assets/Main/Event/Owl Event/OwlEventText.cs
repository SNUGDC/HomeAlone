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

    public static int ClickedTime_OwlEvent;

    void Start()
    {
        ClickedTime_OwlEvent = 0;
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
                button.SetActive(false);
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
