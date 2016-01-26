using UnityEngine;
using System.Collections;

public class MoveSectionByMouseDrag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 scanPos;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(scanPos);
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);

        transform.position = curPosition;
    }
}
