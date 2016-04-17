using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class CheatPanel : MonoBehaviour 
{
    public GameObject cheatButton;
    public VisitFriend[] timeHandler;
    public InputField moneyField;
    public Slider timeSlider;
    float speed;
    int money;
	void OnEnable () 
    {
	   Time.timeScale = 0;
	}
    
    void OnDisable ()
    {
        cheatButton.SetActive(true);
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void Reset()
    {
        Time.timeScale = 1;
        PlayerPrefs.DeleteAll();
        Application.LoadLevel(Application.loadedLevel);
    }
    
    public void Apply()
    {
        for(int i=0; i<timeHandler.Length; i++)
        {
            timeHandler[i].Delta = new TimeSpan(0, 0, (int)timeSlider.value);            
        }
        
        int targetMoney;
        if (!string.IsNullOrEmpty(moneyField.text))
        {
            if (int.TryParse(moneyField.text, out targetMoney))
            {
                MoneySystem.money = targetMoney;
            }
        }
        
        gameObject.SetActive(false);
    }
}
