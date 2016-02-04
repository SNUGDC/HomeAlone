using UnityEngine;
using System.Collections;

public class RemainCostCheat : MonoBehaviour
{
    private int RemainCost;

    public void Cheat()
    {
        Load();
        RemainCost = RemainCost + 10;
        Save();
    }

    void Load()
    {
        RemainCost = PlayerPrefs.GetInt("RemainCost");
    }

    void Save()
    {
        PlayerPrefs.SetInt("RemainCost", RemainCost);
    }
}
