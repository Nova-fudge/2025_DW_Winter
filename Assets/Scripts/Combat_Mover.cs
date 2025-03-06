using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat_Mover : MonoBehaviour
{
    public Transform startPos;

    public bool overEndPoint;
    public bool cardCollision = false;
    public bool placed = true;

    public bool isStationary = false;

    private void OnMouseDrag()
    {
        if (isStationary)
            return;

        placed = false;
        float distance_to_screen = Camera.main.WorldToScreenPoint(transform.position).z;
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Card space"))
        {
            transform.position = collision.gameObject.transform.position;
            overEndPoint = true;
        }

        if (collision.CompareTag("Card"))
            cardCollision = true;
    }

    private void OnTriggerExit(Collider other)
    {
        overEndPoint = false;
        cardCollision = false;
    }

    private void OnMouseUp()
    {
        placed = true;
        if (!overEndPoint || cardCollision)
            transform.position = startPos.position;
    }
}
