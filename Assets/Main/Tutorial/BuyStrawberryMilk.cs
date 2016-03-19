using UnityEngine;
using System.Collections;

public class BuyStrawberryMilk : MonoBehaviour
{
    public void BoughtMilk()
    {
        if (MoneySystem.money == 1300)
        {
            MoneySystem.money -= 1200;
        }
        else return;
    }
}
