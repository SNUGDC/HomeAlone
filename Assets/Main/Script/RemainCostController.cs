using UnityEngine;
using System.Collections;

public class RemainCostController : MonoBehaviour
{
    public int RemainCost;

    void Update()
    {
        if(PlayerPrefs.HasKey("RemainCost"))
            RemainCost = PlayerPrefs.GetInt("RemainCost");

        Save();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RemainCost = RemainCost + 1;
			MoneySystem.money += 100000;
            Save();
        }    
    }

    void Save()
    {
        PlayerPrefs.SetInt("RemainCost", RemainCost);
    }
}