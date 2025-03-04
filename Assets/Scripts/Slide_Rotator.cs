using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide_Rotator : MonoBehaviour
{
    public Rigidbody player;
    bool canRotate = false;

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
        if (Input.GetKeyDown(KeyCode.A) && canRotate)
        {
            targetAngle.z = currentAngle.z + 90;
            rotateTimer = 0f;
        }
        
        if (Input.GetKeyDown(KeyCode.D) && canRotate)
        {
            targetAngle.z = currentAngle.z - 90;
            rotateTimer = 0f;
        }

        rotateTimer += rotateSpeed * Time.deltaTime;

        currentAngle.z = Mathf.LerpAngle(currentAngle.z, targetAngle.z, rotateTimer);

        transform.eulerAngles = currentAngle;

        if (player.velocity == Vector3.zero)
            canRotate = true;
        else
            canRotate = false;
    }
}
