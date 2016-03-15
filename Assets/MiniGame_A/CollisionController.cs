using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollisionController : MonoBehaviour {

    public GameObject Player;
    public GameObject TalkPanel;
    public Text PlayerHP;
    public GameObject Panel;

    int playerHP = 50;

	// Use this for initialization
	void Start ()
    {
        Panel.SetActive(false);
        PlayerHP.text = "HP :" + playerHP;
    }

    void Update()
    {
        GameOver();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        playerHP -= 8;
        PlayerHP.text = "HP :" + playerHP;

        Vector3 PanelPosition = new Vector3(0, 0, 0.0f);
        Quaternion PanelRotation = new Quaternion();
        Instantiate(TalkPanel, PanelPosition, PanelRotation);


    }

    void GameOver()
    {
        if (playerHP <= 0)
        {
            Panel.SetActive(true);
            Destroy(Player);
        }
    }
}
