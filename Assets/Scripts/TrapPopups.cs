using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TrapPopups : MonoBehaviour
{

    public Canvas canvas;
    // if this script is on an object with a collider display the Gui
    void Start()
    {
        canvas.enabled = false;
    }

    void OnTriggerEnter(Collider collider)
    {
        canvas.enabled = true;
    }

    void OnTriggerExit(Collider collider)
    {
        canvas.enabled = false;
    }
}
