using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurotialShopExplain : MonoBehaviour
{
    static int ShopTextClickedTime = 0;
    public Text text;
    public GameObject ShopExplainButton;
    public GameObject BackArrow;
    public GameObject ShopArrow;
    public GameObject AlbumArrow;

    public void IncreaseShopTextClickedTime()
    {
        ShopTextClickedTime += 1;
    }

    void Update()
    {
        switch(ShopTextClickedTime)
        {
            case 1:
                text.text = "게임을 진행하면서 살 수 있는 아이템들이 늘어나요."; 
                break;
            case 2:
                BackArrow.SetActive(true);
                AlbumArrow.SetActive(true);
                TutorialText.ClickedTime = 10;
                Destroy(ShopArrow);
                ShopExplainButton.SetActive(false);
                break;
            default:
                break;
        }
    }
}
