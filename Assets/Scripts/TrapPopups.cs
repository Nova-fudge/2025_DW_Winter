using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TrapPopups : MonoBehaviour
{

    public Canvas canvas;
    public Canvas trapCanvas;
    public TMP_Text text;

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
    }

    private void Update()
    {
        if (PlayerLocation.gameOver && PlayerLocation.traps[trapID])
        {
            Time.timeScale = 0;
            trapMesh.enabled = true;
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
        if (PlayerLocation.traps[trapID])
            text.text = "You have already placed a trap here!";
        else
            text.text = "Setup Trap? Press Space";

        canvas.enabled = true;
        inTrap = true;
    }

    void OnTriggerExit(Collider collider)
    {
        canvas.enabled = false;
        inTrap = false;
    }
}
