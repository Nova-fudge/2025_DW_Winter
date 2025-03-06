using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Detect : MonoBehaviour
{
    public bool hasCollided;

    private void OnTriggerEnter(Collider collision)
    {
        hasCollided = true;
    }

    private void OnTriggerExit(Collider other)
    {
        hasCollided = false;
    }
}
