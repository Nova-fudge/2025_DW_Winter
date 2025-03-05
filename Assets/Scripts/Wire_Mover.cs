using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire_Mover : MonoBehaviour
{
    public Transform startPos;

    public bool overEndPoint;
    public bool wireCollision = false;

    private void OnMouseDrag()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(transform.position).z;
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("endPos"))
        {
            transform.position = collision.gameObject.transform.position;
            overEndPoint = true;
        }

        wireCollision = collision.CompareTag("Wire");
    }

    private void OnTriggerExit(Collider other)
    {
        overEndPoint = false;
    }

    private void OnMouseUp()
    {
        if (!overEndPoint || wireCollision)
            transform.position = startPos.position;
    }
}