using UnityEngine;
using System.Collections;

public class StockingController : MonoBehaviour
{
    public GameObject ObjectEXP;
    public AudioClip ClickStocking;

    Renderer StockingRend;
    Renderer EXPRend;
    int StockingAmount;

    void Start()
    {
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
        PlayerPrefs.SetInt("StockingAmount", PlayerPrefs.GetInt("StockingAmount") - 1);
        GetComponent<AudioSource>().PlayOneShot(ClickStocking);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}