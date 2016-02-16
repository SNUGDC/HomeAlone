using UnityEngine;
using System.Collections;

public class BigDustController : MonoBehaviour
{
    public GameObject EXP;

    Renderer DustRend;
    Renderer EXPRend;

    int BigDustAmount;
    public int MouseDownTime = 0;

    void Start()
    {
        DustRend = GetComponent<Renderer>();
        EXPRend = EXP.GetComponent<Renderer>();
    }

    void Update()
    {
        if(MouseDownTime > 49)
        {
            DestroyFunction();
            MouseDownTime = 1;
        }
    }

    void OnMouseDown()
    {
        MouseDownTime = MouseDownTime + 1;
    }

    void DestroyFunction()
    {
        DustRend.enabled = false;
        EXPRend.enabled = true;
        EXPEffect();
        BigDustAmount = PlayerPrefs.GetInt("BigDustAmount");
        BigDustAmount = BigDustAmount - 1;
        MoneySystem.money += 1;
        PlayerPrefs.SetInt("BigDustAmount", BigDustAmount);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        EXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
