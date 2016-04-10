using UnityEngine;
using System.Collections;

public class BlueGompangController : MonoBehaviour
{
    public GameObject ObjectEXP;
    public AudioClip ClickGompang;

    Renderer GompangRend;
    Renderer EXPRend;
    int BlueGompangAmount;
    public static int DefaultBlueGompangCatch;

    void Start()
    {
        DefaultBlueGompangCatch = PlayerPrefs.GetInt("DefaultBlueGompangCatch");
        GompangRend = GetComponent<Renderer>();
        EXPRend = ObjectEXP.GetComponent<Renderer>();
    }

    void OnMouseEnter()
    {
        GompangRend.enabled = false;
        EXPRend.enabled = true;
        GetComponent<Collider2D>().enabled = false;
        EXPEffect();
        BlueGompangAmount = PlayerPrefs.GetInt("BlueGompangAmount");
        BlueGompangAmount = BlueGompangAmount - 1;
        MoneySystem.money += 200;
        DefaultBlueGompangCatch++;
        PlayerPrefs.SetInt("BlueGompangAmount", BlueGompangAmount);
        PlayerPrefs.SetInt("DefaultBlueGompangCatch", DefaultBlueGompangCatch);
        GetComponent<AudioSource>().PlayOneShot(ClickGompang);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
