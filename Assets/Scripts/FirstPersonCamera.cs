using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    // Variables
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0f;

    bool lockedCursor = true;


    void Start()
    {
        // Lock and Hide the Cursor
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        // Collect Mouse Input

        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotate the Camera around its local X axis

        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(cameraVerticalRotation, 0f, 0f);


        // Rotate the Player Object and the Camera around its Y axis

        player.Rotate(Vector3.up * inputX);

    }
}