using UnityEngine;
using System.Collections;

public class TShirtController : MonoBehaviour
{
    public GameObject ObjectEXP;
    public AudioClip ClickTShirt;

    Renderer TShirtRend;
    Renderer EXPRend;
    int TShirtAmount;
    public static int DefaultTShirtCatch;

    void Start()
    {
        DefaultTShirtCatch = PlayerPrefs.GetInt("DefaultTShirtCatch");
        TShirtRend = GetComponent<Renderer>();
        EXPRend = ObjectEXP.GetComponent<Renderer>();
    }

    void OnMouseEnter()
    {
        TShirtRend.enabled = false;
        EXPRend.enabled = true;
        GetComponent<Collider2D>().enabled = false;
        EXPEffect();
        TShirtAmount = PlayerPrefs.GetInt("TShirtAmount");
        TShirtAmount = TShirtAmount - 1;
        MoneySystem.money += 200;
        DefaultTShirtCatch++;
        PlayerPrefs.SetInt("TShirtAmount", TShirtAmount);
        PlayerPrefs.SetInt("DefaultTShirtCatch", DefaultTShirtCatch);
        GetComponent<AudioSource>().PlayOneShot(ClickTShirt);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
