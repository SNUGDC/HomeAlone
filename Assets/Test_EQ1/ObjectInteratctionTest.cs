using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectInteratctionTest : MonoBehaviour
{
    public Slider Gauge;
    public Slider RemainCost;
    public GameObject balloon;

    public bool istalking;
    public float Cost;
    public float MinGauge;
    public Sprite Red;
    public Sprite Blue;

    void Start()
    {
        istalking = false;
        balloon.GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update()
    {
        ChangeColor();
    }

    void OnMouseDown()
    {
        if (CheckGauge() == false)
        {
            Debug.Log("It looks clean");
            return;
        }

        if (CheckRemainCost() == false)
        {
            Debug.Log("I'm tired");
            return;
        }

        if (balloon.GetComponent<SpriteRenderer>() != null && istalking == false)
        {
            ChangeRendererState();
            Invoke("ChangeRendererState", 2.0f);
        }

        DecreaseGauge();
        UseCost();
    }

    bool CheckGauge()
    {
        if (Gauge.value >= MinGauge)
            return true;
        else return false;
    }

    bool CheckRemainCost()
    {
        if (RemainCost.value >= Cost)
            return true;
        else return false;
    }

    void DecreaseGauge()
    {
        Gauge.value = 0;
    }

    void UseCost()
    {
        RemainCost.value = RemainCost.value - Cost;
    }

    void ChangeColor()
    {
        if (CheckGauge())
            GetComponent<SpriteRenderer>().sprite = Red;
        else GetComponent<SpriteRenderer>().sprite = Blue;
    }

    void ChangeRendererState()
    {
        balloon.GetComponent<SpriteRenderer>().enabled = !balloon.GetComponent<SpriteRenderer>().enabled;
        istalking = !istalking;
    }
}
