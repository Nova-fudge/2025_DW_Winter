using UnityEngine;

public class TrapPopups : MonoBehaviour
{

    public Canvas canvas;
    public Canvas trapCanvas;

    bool inTrap = false;
    public int trapID;

    // if this script is on an object with a collider display the Gui
    void Start()
    {
        canvas.enabled = false;
        trapCanvas.enabled = false;
    }

    private void Update()
    {
        if (PlayerLocation.traps[trapID])
            return;

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
