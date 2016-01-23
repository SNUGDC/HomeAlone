using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectInteraction : MonoBehaviour
{
    public Slider DirtyGauge;

    public float[] Cost;
    public float MinGauge;
    public Sprite[] ObjectImage;

    public Slider RemainCost;

    void Update()
    {
        ChangeSprite();
    }

    void OnMouseDown()
    {
        if (CheckGauge())
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
        else
        {
            Debug.Log("It looks clean");
        }
    }

    bool CheckGauge()
    {
        if (DirtyGauge.value >= MinGauge)
            return true;
        else return false;
    }

    void DecreaseGauge()
    {
        DirtyGauge.value = 0;
    }

    void ChangeSprite()
    {
        if (CheckGauge())
            GetComponent<SpriteRenderer>().sprite = ObjectImage[0];
        else GetComponent<SpriteRenderer>().sprite = ObjectImage[1];
    }

    bool CheckRemainCost()
    {
        if (RemainCost.value >= Cost[1])
            return true;
        else return false;
    }

    void UseCost()
    {
        RemainCost.value = RemainCost.value - Cost[1];
    }
}

