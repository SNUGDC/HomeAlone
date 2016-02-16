using UnityEngine;
using System.Collections;

public class ChangeRoomSprite : MonoBehaviour
{
    public int ManyDust;
    public Sprite CleanRoom;
    public Sprite DirtyRoom;

    private int DustAmount;

    void Start()
    {
        DustAmount = PlayerPrefs.GetInt("DustAmount");
    }

    void Update()
    {
        DustAmount = PlayerPrefs.GetInt("DustAmount");

        if (DustAmount > ManyDust)
            GetComponent<SpriteRenderer>().sprite = DirtyRoom;
        else GetComponent<SpriteRenderer>().sprite = CleanRoom;
    }
}
