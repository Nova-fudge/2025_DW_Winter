using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide_Rotator : MonoBehaviour
{
    public Rigidbody player;
    bool canRotate = false;
    public bool puzzleSolved = false;

    Vector3 currentAngle;
    Vector3 targetAngle;
    float rotateTimer = 0f;

    public float rotateSpeed = 1f;
    public float movesUsed = 0f;

    private void Start()
    {
        currentAngle = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && canRotate && !puzzleSolved)
        {
            targetAngle.z = currentAngle.z + 90;
            rotateTimer = 0f;
            movesUsed++;
        }
        
        if (Input.GetKeyDown(KeyCode.D) && canRotate && !puzzleSolved)
        {
            targetAngle.z = currentAngle.z - 90;
            rotateTimer = 0f;
            movesUsed++;
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
