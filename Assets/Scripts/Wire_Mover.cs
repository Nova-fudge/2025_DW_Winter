using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire_Mover : MonoBehaviour
{
    public Transform startPos;

    public List<AudioClip> spark;
    AudioSource audio;

    public bool overEndPoint;
    public bool wireCollision = false;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

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

        if (collision.CompareTag("Wire"))
            wireCollision = true;
    }

    private void OnTriggerExit(Collider other)
    {
        overEndPoint = false;
        wireCollision = false;
    }

    private void OnMouseUp()
    {
        int audioID = Random.Range(0, 4);
        audio.clip = spark[audioID];
        audio.Play();

        if (!overEndPoint || wireCollision)
            transform.position = startPos.position;
    }
}