using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    public GameObject player;
    public Rigidbody playerRigid;
    public float speed;
    public float maxVelocity;
    public float currentVelocity;

    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
        player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = (Vector3.forward) * speed;
        Vector3 side = (Vector3.right) * speed;

        if (Input.GetKey(KeyCode.W))
        {
           playerRigid.AddForce(forward, ForceMode.Force);
           Debug.Log("pressing W");
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerRigid.AddForce(-side, ForceMode.Force);
            Debug.Log("pressing A");
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerRigid.AddForce(-forward, ForceMode.Force);
            Debug.Log("pressing S");
        }

        if(Input.GetKey(KeyCode.D))
        {
            playerRigid.AddForce(side, ForceMode.Force);
            Debug.Log("pressing D");
        }
    }
}
