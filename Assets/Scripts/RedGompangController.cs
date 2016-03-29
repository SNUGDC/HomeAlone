using UnityEngine;
using System.Collections;

public class RedGompangController : MonoBehaviour
{
    public GameObject ObjectEXP;
    public AudioClip ClickGompang;

    Renderer GompangRend;
    Renderer EXPRend;
    int RedGompangAmount;
    public static int DefaultRedGompangCatch;

    void Start()
    {
        DefaultRedGompangCatch = PlayerPrefs.GetInt("DefaultRedGompangCatch");
        GompangRend = GetComponent<Renderer>();
        EXPRend = ObjectEXP.GetComponent<Renderer>();
    }

    void OnMouseEnter()
    {
        GompangRend.enabled = false;
        EXPRend.enabled = true;
        GetComponent<Collider2D>().enabled = false;
        EXPEffect();
        RedGompangAmount = PlayerPrefs.GetInt("RedGompangAmount");
        RedGompangAmount = RedGompangAmount - 1;
        MoneySystem.money += 200;
        DefaultRedGompangCatch++;
        PlayerPrefs.SetInt("RedGompangAmount", RedGompangAmount);
        PlayerPrefs.SetInt("DefaultRedGompangCatch", DefaultRedGompangCatch);
        GetComponent<AudioSource>().PlayOneShot(ClickGompang);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
