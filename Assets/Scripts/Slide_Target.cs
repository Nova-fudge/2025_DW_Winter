using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slide_Target : MonoBehaviour
{
    public Material hit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = hit;
            Debug.Log("I AM HIT");
        }
    }
}
