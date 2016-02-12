using UnityEngine;
using System.Collections;

public class DustController : MonoBehaviour
{
    public GameObject EXP;

    Renderer DustRend;
    Renderer EXPRend;

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
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        EXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
