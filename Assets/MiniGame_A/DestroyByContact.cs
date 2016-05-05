using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    public GameObject Enemy;

    void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag != "ammoMiniEnemy") {
			Destroy (Enemy);
		}
    }
}
