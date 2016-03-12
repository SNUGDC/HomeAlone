using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour
{
    public Camera Cam;
    Vector3 MousePos = Input.mousePosition;

    void OnMouseDrag()
    {
        Debug.Log(Input.mousePosition);
        GetComponent<Transform>().position = Cam.ScreenToWorldPoint(new Vector3(MousePos.x, MousePos.y, -Cam.transform.position.z));
    }
}
