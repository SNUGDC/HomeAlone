using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour
{
    public Camera Cam;
    Vector3 MousePos;

    void Update()
    {
        MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Cam.transform.position.z);
    }

    void OnMouseDrag()
    {
        GetComponent<Transform>().position = Cam.ScreenToWorldPoint(MousePos);
    }

    void OnMouseUp()
    {

    }

    void OnTriggerStay2D(Collider2D Coll)
    {
        Debug.Log("제발 반응좀 해줘ㅠㅠ");
        if (Coll.name != null)
            Debug.Log(Coll.name);
    }
}
