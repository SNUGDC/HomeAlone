using UnityEngine;
using System.Collections;

public class SelectBehavior : MonoBehaviour
{
    private GameObject Select_Panel;
    public GameObject Player;
    private GameObject Desk;
    private float StartTime;
    private float ElapseTime;
    public static int LeisureTime;

    void Awake()
    {
        Select_Panel = GameObject.Find("Select_Panel");
        Desk = GameObject.Find("Desk");
    }

	void Start ()
    {
		LeisureTime = PlayerPrefs.GetInt("LeisureTime");
        Select_Panel.SetActive(false);
    }

    void Update ()
    {
        if (Player.transform.position == new Vector3(-4,2,0))
        {
            ElapseTime = Time.time;

            if (ElapseTime - StartTime >= 8)
            {
                Player.transform.position = new Vector3(0, 0, 0);
                LeisureTime += 30;
                Debug.Log(LeisureTime);
            }
        }
		save ();
	}

    public void StudyInfrontDesk()
    {
        if (Player.transform.position != new Vector3(-4, 2, 0))
        {
            Player.transform.position = new Vector3(-4, 2, 0);
            StartTime = Time.time;
            Debug.Log(StartTime);
            Select_Panel.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        Select_Panel.SetActive(true);
    }

	void save(){
		PlayerPrefs.SetInt ("LeisureTime", LeisureTime);
	}

}
