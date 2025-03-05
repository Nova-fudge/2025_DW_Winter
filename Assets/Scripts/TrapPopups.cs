using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrapPopups : MonoBehaviour
{

    public GameObject trapText;
    // if this script is on an object with a collider display the Gui
    void OnTriggerEnter()
    {
        Instantiate(trapText);
    }


    void OnTriggerExit()
    {
        Destroy(trapText);
    }
}
