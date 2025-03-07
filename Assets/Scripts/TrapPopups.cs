using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TrapPopups : MonoBehaviour
{

    public Canvas canvas;
    public Canvas trapCanvas;
    public Canvas winScreen;
    public TMP_Text text;
    public Rigidbody roof;
    public Camera playerCam;
    public Canvas midWinScreen;

    bool inTrap = false;
    public int trapID;

    MeshRenderer trapMesh;

    // if this script is on an object with a collider display the Gui
    void Start()
    {
        trapMesh = GetComponent<MeshRenderer>();
        text.text = "Setup Trap? Press Space";
        trapMesh.enabled = false;
        canvas.enabled = false;
        trapCanvas.enabled = false;
        winScreen.enabled = false;
        midWinScreen.enabled = false;
    }

    private void Update()
    {
        if (PlayerLocation.gameOver && PlayerLocation.traps[trapID])
        {
            trapMesh.enabled = true;
            Object.Destroy(roof);
            canvas.enabled = true;
            if (PlayerLocation.traps[4] &&
                PlayerLocation.traps[5] &&
                PlayerLocation.traps[7] &&
                PlayerLocation.traps[8] && 
                PlayerLocation.traps[9])
            {
                winScreen.enabled = true;
                playerCam.transform.position = new Vector3(0, 72, 42);
            }
            else
            {
                midWinScreen.enabled = true;
                playerCam.transform.position = new Vector3(0, 72, 42);
            }
        }

        if (PlayerLocation.traps[trapID])
        {
            text.text = "You have already placed a trap here!";
            return;
        }
            

        if (Input.GetKeyDown(KeyCode.Space) && inTrap)
        {
            PlayerLocation.chosenTrapNumber(trapID);
            canvas.enabled = false;
            trapCanvas.enabled = true;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && inTrap)
        {
            canvas.enabled = false;
            trapCanvas.enabled = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        canvas.enabled = true;
        inTrap = true;
    }

    void OnTriggerExit(Collider collider)
    {
        canvas.enabled = false;
        inTrap = false;
    }
}
