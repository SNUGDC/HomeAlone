using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SheepEventText : MonoBehaviour
{
    public Text text;
    public GameObject button;
    public GameObject Sheep_Normal;
    public GameObject Sheep_CantCook;
    public GameObject SheepForText;

    public static int ClickedTime_SheepEvent;

    void Start()
    {
        ClickedTime_SheepEvent = 0;
    }

    void Update()
    {
        switch (ClickedTime_SheepEvent)
        {
            case 0:
                button.SetActive(true);
                text.text = "매번 얻어먹기만 하는 건 좀 눈치가 보여서 말야.";
                break;
            case 1:
                text.text = "오늘은 내가! 떡볶이를 만들어 주지!";
                break;
            case 2:
                text.text = "떡, 어묵, 파, 양념장만 있으면 간단하게 만들 수 있다구.";
                break;
            case 3:
                text.text = "그럼 먼저 냄비에 물을 받아서...";
                break;
            case 4:
                SpriteEnabled(Sheep_CantCook, true);
                SpriteEnabled(Sheep_Normal, false);
                button.SetActive(false);
                break;
            case 5:
                text.text = "(냄비를 향해 손을 뻗으나 키가 작아서 손잡이가 닿질 않는듯 하다)";
                break;
            case 6:
                button.SetActive(false);
                break;
            case 7:
                text.text = "냄ㅂ...";
                break;
            case 8:
                button.SetActive(false);
                break;
            case 9:
                text.text = "냄비..냄비에...";
                break;
            case 10:
                text.text = "물을..받아야...하는데...";
                break;
            case 11:
                button.SetActive(false);
                break;
            case 12:
                text.text = ".......";
                break;
            case 13:
                text.text = "마트 갔다올게.";
                break;
            case 14:
                SpriteEnabled(Sheep_CantCook, false);
                button.SetActive(false);
                break;
            case 15:
                text.text = "결국 인스턴트 떡볶이를 먹을 수 밖에 없었다...";
                break;
            case 16:
                SceneManager.LoadScene("Main");
                break;
            default:
                break;
        }
    }

    void SpriteEnabled(GameObject Object, bool b)
    {
        Object.GetComponent<SpriteRenderer>().enabled = b;
    }

    public void IsClicked()
    {
        ClickedTime_SheepEvent = ClickedTime_SheepEvent + 1;
    }
}