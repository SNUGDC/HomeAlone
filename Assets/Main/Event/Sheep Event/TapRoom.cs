using UnityEngine;
using System.Collections;

public class TapRoom : MonoBehaviour
{
    public GameObject button;

    void OnMouseUp()
    {
        switch(SheepEventText.ClickedTime_SheepEvent)
        {
            case 4:
                SheepEventText.ClickedTime_SheepEvent = 5;
                button.SetActive(true);
                break;
            case 5:
                SheepEventText.ClickedTime_SheepEvent = 6;
                button.SetActive(true);
                break;
            case 7:
                SheepEventText.ClickedTime_SheepEvent = 8;
                button.SetActive(true);
                break;
            case 8:
                SheepEventText.ClickedTime_SheepEvent = 9;
                button.SetActive(true);
                break;
            case 10:
                SheepEventText.ClickedTime_SheepEvent = 11;
                button.SetActive(true);
                break;
            case 11:
                SheepEventText.ClickedTime_SheepEvent = 12;
                button.SetActive(true);
                break;
            case 14:
                SheepEventText.ClickedTime_SheepEvent = 15;
                button.SetActive(true);
                break;
            case 15:
                SheepEventText.ClickedTime_SheepEvent = 16;
                button.SetActive(true);
                break;
            case 16:
                SheepEventText.ClickedTime_SheepEvent = 17;
                button.SetActive(true);
                break;
            case 18:
                SheepEventText.ClickedTime_SheepEvent = 19;
                button.SetActive(true);
                break;
            case 19:
                SheepEventText.ClickedTime_SheepEvent = 20;
                button.SetActive(true);
                break;
            case 21:
                SheepEventText.ClickedTime_SheepEvent = 22;
                button.SetActive(true);
                break;
            default:
                break;
        }
    }
}
