using UnityEngine;
using System.Collections;

public class DustController : MonoBehaviour
{
    public GameObject EXP;

    Renderer DustRend;
    Renderer EXPRend;
    int DustAmount;

    void Start()
    {
        DustRend = GetComponent<Renderer>();
        EXPRend = EXP.GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        Debug.Log("눌림!");
        DustRend.enabled = false;
        EXPRend.enabled = true;
        EXPEffect();
        DustAmount = PlayerPrefs.GetInt("DustAmount");
        DustAmount = DustAmount - 1;
        PlayerPrefs.SetInt("DustAmount", DustAmount);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        EXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
