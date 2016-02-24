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
            case 6:
                SheepEventText.ClickedTime_SheepEvent = 7;
                button.SetActive(true);
                break;
            case 8:
                SheepEventText.ClickedTime_SheepEvent = 9;
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
            default:
                break;
        }
    }
}
