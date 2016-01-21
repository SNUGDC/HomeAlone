using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectInteraction : MonoBehaviour
{
    public Slider Gauge;

    public float Cost;
    public float MinGauge;
    public Sprite Clean;
    public Sprite Dirty;

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
        if (Gauge.value >= MinGauge)
            return true;
        else return false;
    }

    void DecreaseGauge()
    {
        Gauge.value = 0;
    }

    void ChangeSprite()
    {
        if (CheckGauge())
            GetComponent<SpriteRenderer>().sprite = Dirty;
        else GetComponent<SpriteRenderer>().sprite = Clean;
    }

    bool CheckRemainCost()
    {
        if (RemainCost.value >= Cost)
            return true;
        else return false;
    }

    void UseCost()
    {
        RemainCost.value = RemainCost.value - Cost;
    }
}
