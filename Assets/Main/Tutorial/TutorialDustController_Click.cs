using UnityEngine;
using System.Collections;

public class TutorialDustController_Click : MonoBehaviour
{
    public int Order;
    public static int OrderNow;
    public AudioClip ClickDust;
    public GameObject Arrow;
    public GameObject ObjectEXP;
    public GameObject button;

    Renderer DustRend;
    Renderer EXPRend;

    void Start()
    {
        DustRend = GetComponent<Renderer>();
        EXPRend = ObjectEXP.GetComponent<Renderer>();
    }

    void Update()
    {
        if (OrderNow == Order)
        {
            Arrow.SetActive(true);
        }
        else return;
    }

    void OnMouseDown()
    {
        if (OrderNow == Order)
        {
            OrderNow += 1;
            DustRend.enabled = false;
            EXPRend.enabled = true;
            Arrow.SetActive(false);
            EXPEffect();
            GetComponent<AudioSource>().PlayOneShot(ClickDust);
            MoneySystem.money += 100;
            FinishCleaningDust();
            Destroy(gameObject, 1);
        }
        else return;
    }

    void FinishCleaningDust()
    {
        if (Order == 3)
        {
            TutorialText.ClickedTime = 7;
            button.SetActive(true);
            TutorialDustController_Swipe.Tut_Swipe = true;
        }
        else return;
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
