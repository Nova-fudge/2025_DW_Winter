using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    public CharacterController controller;
    public Scene_Switcher sceneSwitcher;

    public float speed = 12f;
    public float runningSpeed = 20f;

    public Canvas canvas;

    void Start()
    {
        canvas.enabled = false;
        Debug.Log(":( i have a value that is null");
        
        if (PlayerLocation.previousPlayerTransform != null)
        {
            Debug.Log("wow i have a value that is not null");
            this.transform.position = sceneSwitcher.LoadLocation().position;
        }

    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * speed * runningSpeed * Time.deltaTime);
        }

        sceneSwitcher.SaveLocation(this.transform);

    }
}