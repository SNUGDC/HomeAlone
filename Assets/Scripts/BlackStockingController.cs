using UnityEngine;
using System.Collections;

public class BlackStockingController : MonoBehaviour
{
    public GameObject ObjectEXP;
    public AudioClip ClickStocking;
    public static int DefaultBlackStockingCatch;

    Renderer StockingRend;
    Renderer EXPRend;
    int StockingAmount;

    void Start()
    {
        DefaultBlackStockingCatch = PlayerPrefs.GetInt("DefaultBlackStockingCatch");
        StockingRend = GetComponent<Renderer>();
        EXPRend = ObjectEXP.GetComponent<Renderer>();
    }

    void OnMouseEnter()
    {
        StockingRend.enabled = false;
        EXPRend.enabled = true;
        GetComponent<Collider2D>().enabled = false;
        EXPEffect();
        MoneySystem.money += 150;
        DefaultBlackStockingCatch++;
        PlayerPrefs.SetInt("StockingAmount", PlayerPrefs.GetInt("StockingAmount") - 1);
        PlayerPrefs.SetInt("DefaultBlackStockingCatch", DefaultBlackStockingCatch);
        GetComponent<AudioSource>().PlayOneShot(ClickStocking);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}