using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slide_Target : MonoBehaviour
{
    public Material hit;
    public bool amHit = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = hit;
            amHit = true;
        }
    }
}
