using UnityEngine;
using System.Collections;

public class TutorialDustController_Swipe : MonoBehaviour
{
    public static bool Tut_Swipe = false;

    public GameObject ObjectEXP;
    public AudioClip ClickDust;

    Renderer DustRend;
    Renderer EXPRend;
    int DustAmount;

    void Start()
    {
        DustRend = GetComponent<Renderer>();
        EXPRend = ObjectEXP.GetComponent<Renderer>();
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update()
    {
        if(Tut_Swipe)
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    void OnMouseEnter()
    {
        Tut_Swipe = false;
        DustRend.enabled = false;
        EXPRend.enabled = true;
        GetComponent<Collider2D>().enabled = false;
        EXPEffect();
        DustAmount = DustAmount - 1;
        MoneySystem.money += 100;
        GetComponent<AudioSource>().PlayOneShot(ClickDust);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
