using UnityEngine;
using System.Collections;

public class CreateDust : MonoBehaviour
{
    public GameObject Dust;

    void OnMouseDown()
    {
        Instantiate(Dust);
    }
}
