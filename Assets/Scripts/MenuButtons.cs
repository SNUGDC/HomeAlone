using UnityEngine;
using System.Collections;

public class MenuButtons : MonoBehaviour
{
	public GameObject Panel;
	bool Open = false;

	public void OpenPanel()
	{
		if (Open == false)
		{
			Open = true;
			Panel.SetActive (true);
		}
	}

	public void ClosePanel()
	{
		if (Open == true)
		{
			Open = false;
			Panel.SetActive (false);
		}
	}
}
