using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectInteraction : MonoBehaviour
{
    public float[] Cost;
    public float[] MinDirtyGauge;
    public Sprite[] ObjectImage;
    public GameObject NotEnoughCost_Panel;
    private GameObject Player;

    public int DirtyGauge;
    public int RemainCost;

    private int s;
    private string VariableName;

    void Awake()
    {
        NotEnoughCost_Panel = GameObject.Find("NotEnoughCost_Panel");
        Player = GameObject.Find("Player");
    }

    void Start()
    {
        VariableName = GetComponent<DirtyTimer>().VariableName;
        NotEnoughCost_Panel.SetActive(false);
        RemainCost = PlayerPrefs.GetInt("RemainCost");
    }

    void Update()
    {
        DirtyGauge = GetComponent<DirtyTimer>().DirtyGauge;
        RemainCost = PlayerPrefs.GetInt("RemainCost");
        s = CheckGauge();
        ChangeSprite();
    }

    void OnMouseDown()
    {
        if (Player.transform.position == new Vector3(-4,2,0))
        {
            Debug.Log("You can't do that Now.");
        }

        else if (s == 0)
        {
            Debug.Log("It looks clean");
            return;
        }
        else if (CheckRemainCost())
        {
            DecreaseGauge();
            UseCost();
            return;
        }
        else
        {
        NotEnoughCost_Panel.SetActive(true);
            return;
        }
        
    }

    int CheckGauge()
    {
        if (MinDirtyGauge[0] == DirtyGauge)
            return 0;
        else if (MinDirtyGauge[1] >= DirtyGauge)
            return 1;
        else if (MinDirtyGauge[2] >= DirtyGauge)
            return 2;
        else return 3;
    }

    void DecreaseGauge()
    {
        DirtyGauge = 0;
        Save(DirtyGauge);
    }

    void ChangeSprite()
    {
        GetComponent<SpriteRenderer>().sprite = ObjectImage[s];
    }

    bool CheckRemainCost()
    {
        if (RemainCost >= Cost[s])
            return true;
        return false;
    }

    void UseCost()
    {
        RemainCost = RemainCost - (int)Cost[s];
        PlayerPrefs.SetInt("RemainCost", RemainCost);
    }

    void Save(int var)
    {
        PlayerPrefs.SetInt(VariableName, var);
    }
}

