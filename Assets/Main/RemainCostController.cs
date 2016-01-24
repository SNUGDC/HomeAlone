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
            Debug.Log("눌리긴하냐");
            RemainCost = RemainCost + 1;
            Save();
        }    
    }

    void Save()
    {
        PlayerPrefs.SetInt("RemainCost", RemainCost);
    }
}