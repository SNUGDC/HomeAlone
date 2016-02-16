using UnityEngine;
using System.Collections;

public class DustController : MonoBehaviour
{
    public GameObject ObjectEXP;
    public AudioClip ClickDust;

    Renderer DustRend;
    Renderer EXPRend;
    int DustAmount;

    void Start()
    {
        DustRend = GetComponent<Renderer>();
        EXPRend = ObjectEXP.GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        DustRend.enabled = false;
        EXPRend.enabled = true;
        EXPEffect();
        DustAmount = PlayerPrefs.GetInt("DustAmount");
        DustAmount = DustAmount - 1;
        MoneySystem.money += 100;
        PlayerPrefs.SetInt("DustAmount", DustAmount);
        GetComponent<AudioSource>().PlayOneShot(ClickDust);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
