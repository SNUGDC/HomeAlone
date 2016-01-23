using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectInteraction : MonoBehaviour
{
    public Slider DirtyGauge;

    public float[] Cost;
    public float[] MinDirtyGauge;
    public Sprite[] ObjectImage;

    public Slider RemainCost;

    private int s;

    void Update()
    {
        ChangeSprite();
    }

    void OnMouseDown()
    {
        if (s == 0)
        {
            Debug.Log("It looks clean");
        }
        else
        {
            if (CheckRemainCost())
            {
                DecreaseGauge();
                UseCost();
            }
            else
            {
                Debug.Log("I'm tired");
            }
        }
    }

    int CheckGauge()
    {
        if (MinDirtyGauge[0] == DirtyGauge.value)
            return 0;
        else if (MinDirtyGauge[1] >= DirtyGauge.value)
            return 1;
        else if (MinDirtyGauge[2] >= DirtyGauge.value)
            return 2;
        else if (MinDirtyGauge[3] >= DirtyGauge.value)
            return 3;
        else return 4;
    }

    void DecreaseGauge()
    {
        DirtyGauge.value = 0;
    }

    void ChangeSprite()
    {
        GetComponent<SpriteRenderer>().sprite = ObjectImage[s];
    }

    bool CheckRemainCost()
    {
        if (RemainCost.value >= Cost[s])
            return true;
        else return false;
    }

    void UseCost()
    {
        RemainCost.value = RemainCost.value - Cost[s];
    }
}

