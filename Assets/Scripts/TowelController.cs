using UnityEngine;
using System.Collections;

public class TowelController : MonoBehaviour
{
    public GameObject ObjectEXP;
    public AudioClip ClickTowel;

    Renderer TowelRend;
    Renderer EXPRend;
    int TowelAmount;
    public static int DefaultTowelCatch;

    void Start()
    {
		DefaultTowelCatch = PlayerPrefs.GetInt("DefaultTowelCatch");
        TowelRend = GetComponent<Renderer>();
        EXPRend = ObjectEXP.GetComponent<Renderer>();
    }

    void OnMouseEnter()
    {
        TowelRend.enabled = false;
        EXPRend.enabled = true;
        GetComponent<Collider2D>().enabled = false;
        EXPEffect();
        TowelAmount = PlayerPrefs.GetInt("TowelAmount");
        TowelAmount = TowelAmount - 1;
        MoneySystem.money += 200;
        DefaultTowelCatch++;
        PlayerPrefs.SetInt("TowelAmount", TowelAmount);
        PlayerPrefs.SetInt("DefaultTowelCatch", DefaultTowelCatch);
        GetComponent<AudioSource>().PlayOneShot(ClickTowel);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
