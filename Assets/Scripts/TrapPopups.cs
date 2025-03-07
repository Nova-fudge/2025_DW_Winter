using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TrapPopups : MonoBehaviour
{

    public Canvas canvas;
    public Canvas trapCanvas;
    public TMP_Text text;
    public Rigidbody roof;

    bool inTrap = false;
    public int trapID;

    MeshRenderer trapMesh;

    // if this script is on an object with a collider display the Gui
    void Start()
    {
        trapMesh = GetComponent<MeshRenderer>();
        trapMesh.enabled = false;
        canvas.enabled = false;
        trapCanvas.enabled = false;
        
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
            text.text = "Congrats! You finished the game! Did you do well? You got all of the right!";
        };

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
