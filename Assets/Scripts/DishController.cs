using UnityEngine;
using System.Collections;

public class DishController : MonoBehaviour
{
    public GameObject ObjectEXP;
    public AudioClip ClickDish;

    Renderer DishRend;
    Renderer EXPRend;
    int DishAmount;
    public static int DefaultDishCatch;

    void Start()
    {
        DefaultDishCatch = PlayerPrefs.GetInt("DefaultDishCatch");
        DishRend = GetComponent<Renderer>();
        EXPRend = ObjectEXP.GetComponent<Renderer>();
    }

    void OnMouseEnter()
    {
        DishRend.enabled = false;
        EXPRend.enabled = true;
        GetComponent<Collider2D>().enabled = false;
        EXPEffect();
        DishAmount = PlayerPrefs.GetInt("DishAmount");
        DishAmount = DishAmount - 1;
        MoneySystem.money += 100;
        DefaultDishCatch++;
        PlayerPrefs.SetInt("DishAmount", DishAmount);
        PlayerPrefs.SetInt("DefaultDishCatch", DefaultDishCatch);
        GetComponent<AudioSource>().PlayOneShot(ClickDish);
        Destroy(gameObject, 1);
    }

    void EXPEffect()
    {
        ObjectEXP.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }
}
