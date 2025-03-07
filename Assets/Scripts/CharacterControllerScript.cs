using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    public static CharacterControllerScript Instance;

    public CharacterController controller;
    public Scene_Switcher sceneSwitcher;

    public float speed = 12f;
    public float runningSpeed = 20f;

    public Canvas canvas;

    public Box_Detect respawnBox;

    public GameObject dontDestroy;

    private bool hasRun = false;

    private Vector3 previousPlayerPos;

    public Camera playerCamera;

    public AudioSource walkSFX;
    bool isWalking = false;

    void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        DontDestroyOnLoad(transform.gameObject);
        canvas.enabled = false;
        Debug.Log(":( i have a value that is null");
        Cursor.visible = false;
    }

    private void Start()
    {
        Instance = this;
    }

    void Update()
    {
        playerCamera.enabled = !PlayerLocation.inTrap;

        Debug.Log(PlayerLocation.sliderDone);

        Debug.Log("Holder is " + previousPlayerPos);
        if (hasRun == false)
        {
            previousPlayerPos = transform.position;
            hasRun = true;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * speed * runningSpeed * Time.deltaTime);
        }

        if (x != 0 || z != 0)
        {
            if (isWalking)
                return;
            walkSFX.Play();
            isWalking = true;
        }
        else
        {
            isWalking = false;
            walkSFX.Stop();
        }
    }
}