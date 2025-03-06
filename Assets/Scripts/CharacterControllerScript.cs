using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    public CharacterController controller;
    public Scene_Switcher sceneSwitcher;

    public float speed = 12f;
    public float runningSpeed = 20f;

    public Canvas canvas;

    public Box_Detect respawnBox;

    void Awake()
    {
        canvas.enabled = false;
        Debug.Log(":( i have a value that is null");
    }

    void Start()
    {
        sceneSwitcher.LoadLocation();
    }
    void Update()
    {
        sceneSwitcher.SaveLocation(this.transform);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * speed * runningSpeed * Time.deltaTime);
        }

    }
}