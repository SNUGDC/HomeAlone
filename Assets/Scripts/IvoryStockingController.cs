using UnityEngine;
using System.Collections;

public class IvoryStockingController : MonoBehaviour
{
    public GameObject ObjectEXP;
    public AudioClip ClickStocking;
    public static int DefaultIvoryStockingCatch;

    Renderer StockingRend;
    Renderer EXPRend;
    int StockingAmount;

    void Start()
    {
        DefaultIvoryStockingCatch = PlayerPrefs.GetInt("DefaultIvoryStockingCatch");
        StockingRend = GetComponent<Renderer>();
        EXPRend = ObjectEXP.GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        StockingRend.enabled = false;
        EXPRend.enabled = true;
        GetComponent<Collider2D>().enabled = false;
        EXPEffect();
        MoneySystem.money += 150;
        DefaultIvoryStockingCatch++;
        PlayerPrefs.SetInt("StockingAmount", PlayerPrefs.GetInt("StockingAmount") - 1);
        PlayerPrefs.SetInt("DefaultIvoryStockingCatch", DefaultIvoryStockingCatch);
        GetComponent<AudioSource>().PlayOneShot(ClickStocking);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
