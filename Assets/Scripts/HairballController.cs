using UnityEngine;
using System.Collections;

public class HairballController : MonoBehaviour
{
    public GameObject ObjectEXP;
    public AudioClip ClickHairball;

    Renderer HairballRend;
    Renderer EXPRend;
    int HairballAmount;
    public static int DefaultHairballCatch;

    void Start()
    {
		DefaultHairballCatch = PlayerPrefs.GetInt("DefaultHairballCatch");
        HairballRend = GetComponent<Renderer>();
        EXPRend = ObjectEXP.GetComponent<Renderer>();
    }

    void OnMouseEnter()
    {
        HairballRend.enabled = false;
        EXPRend.enabled = true;
        GetComponent<Collider2D>().enabled = false;
        EXPEffect();
        HairballAmount = PlayerPrefs.GetInt("HairballAmount");
        HairballAmount = HairballAmount - 1;
        MoneySystem.money += 100;
        DefaultHairballCatch++;
        PlayerPrefs.SetInt("HairballAmount", HairballAmount);
        PlayerPrefs.SetInt("DefaultHairballCatch", DefaultHairballCatch);
        GetComponent<AudioSource>().PlayOneShot(ClickHairball);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
