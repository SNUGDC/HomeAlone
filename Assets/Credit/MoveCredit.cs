using UnityEngine;
using System.Collections;

public class MoveCredit : MonoBehaviour
{
    public GameObject CreditImage1;
    public GameObject CreditImage2;
    public GameObject CreditImage3;
    public GameObject CircleArrowRight;
    public GameObject CircleArrowLeft;

    public static int CreditPage;

    void Start()
    {
        CreditPage = 1;
    }

    void Update()
    {
        if(CreditPage == 1)
        {
            CreditImage1.SetActive(true);
            CreditImage2.SetActive(false);
            CreditImage3.SetActive(false);
            CircleArrowLeft.SetActive(false);
            CircleArrowRight.SetActive(true);
        }
        else if(CreditPage == 2)
        {
            CreditImage1.SetActive(false);
            CreditImage2.SetActive(true);
            CreditImage3.SetActive(false);
            CircleArrowLeft.SetActive(true);
            CircleArrowRight.SetActive(true);
        }
        else if(CreditPage == 3)
        {
            CreditImage1.SetActive(false);
            CreditImage2.SetActive(false);
            CreditImage3.SetActive(true);
            CircleArrowLeft.SetActive(true);
            CircleArrowRight.SetActive(false);
        }
    }

    public void PushLeftButton()
    {
        CreditPage -= 1;
    }

    public void PushRightButton()
    {
        CreditPage += 1;
    }
}
