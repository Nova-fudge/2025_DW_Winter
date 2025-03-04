using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAt : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity;
    void Update()
    {
        rotationY += Input.GetAxis("MouseX") * sensitivity;
        rotationX += Input.GetAxis("MouseY") * sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}