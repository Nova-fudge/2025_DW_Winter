using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterControllerScript : MonoBehaviour
{
    public GameObject player;
    public Rigidbody playerRigid;

    public float speed;

    public float maxZVelocity;
    public float minZVelocity;
    public float currentZVelocity;

    public float maxXVelocity;
    public float minXVelocity;
    public float currentXVelocity;

    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
        player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 forward = (Vector3.forward) * speed;
        Vector3 side = (Vector3.right) * speed;

        currentZVelocity = playerRigid.velocity.z;
        currentXVelocity = playerRigid.velocity.x;

        //forwards
        if (Input.GetKey(KeyCode.W))
        {
           playerRigid.AddForce(forward, ForceMode.Force);
           
           if (currentZVelocity > maxZVelocity)
            {
                playerRigid.AddForce(-forward , ForceMode.Force);
            }

           if (Input.GetKeyUp(KeyCode.W))
            {
                playerRigid.AddForce(-forward / 2, ForceMode.Force);
            }
           
           Debug.Log("pressing W");
        }

        //left
        if (Input.GetKey(KeyCode.A))
        {
            playerRigid.AddForce(-side, ForceMode.Force);

            if (currentXVelocity < minXVelocity)
            {
                playerRigid.AddForce(side, ForceMode.Force);
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                playerRigid.AddForce(side * 2, ForceMode.Force);
            }
            Debug.Log("pressing A");
        }

        //backwards
        if (Input.GetKey(KeyCode.S))
        {
            playerRigid.AddForce(-forward, ForceMode.Force);

            if (currentZVelocity < minZVelocity)
            {
                playerRigid.AddForce(forward, ForceMode.Force);
            }

            if (Input.GetKeyUp(KeyCode.S))
            {
                playerRigid.AddForce(forward * 2, ForceMode.Force);
            }
            Debug.Log("pressing S");
        }

        //right
        if(Input.GetKey(KeyCode.D))
        {
            playerRigid.AddForce(side, ForceMode.Force);

            if (currentXVelocity > maxXVelocity)
            {
                playerRigid.AddForce(-side, ForceMode.Force);
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                playerRigid.AddForce(-side / 2, ForceMode.Force);
            }
            Debug.Log("pressing D");
        }
    }
}
