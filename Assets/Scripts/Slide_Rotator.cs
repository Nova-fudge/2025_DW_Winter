using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide_Rotator : MonoBehaviour
{
    Vector3 currentAngle;
    Vector3 targetAngle;
    float rotateTimer = 0f;

    public float rotateSpeed = 1f;

    private void Start()
    {
        currentAngle = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            targetAngle.z = currentAngle.z + 90;
            rotateTimer = 0f;
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            targetAngle.z = currentAngle.z - 90;
            rotateTimer = 0f;
        }

        rotateTimer += rotateSpeed * Time.deltaTime;

        currentAngle.z = Mathf.LerpAngle(currentAngle.z, targetAngle.z, rotateTimer);

        transform.eulerAngles = currentAngle;
    }
}
