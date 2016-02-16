using UnityEngine;
using System.Collections;

public class DustController : MonoBehaviour
{
    public GameObject ObjectEXP;

    Renderer DustRend;
    Renderer EXPRend;
    int DustAmount;
    int EXP;

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
        EXP = PlayerPrefs.GetInt("EXP");
        DustAmount = DustAmount - 1;
        EXP = EXP + 100;
        PlayerPrefs.SetInt("DustAmount", DustAmount);
        PlayerPrefs.SetInt("EXP", EXP);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
