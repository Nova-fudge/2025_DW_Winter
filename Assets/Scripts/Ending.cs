using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public Canvas winScreen;
    public Canvas midWinScreen;
    public Camera endCamera;

    private void Start()
    {
        winScreen.enabled = false;
        midWinScreen.enabled = false;
        endCamera.enabled = false;
    }

    void Update()
    {
        if (PlayerLocation.sliderDone &&
            PlayerLocation.webDone &&
            PlayerLocation.wiresDone &&
            PlayerLocation.glyphsDone &&
            PlayerLocation.combatDone)
        {
            PlayerLocation.endGame();
        }

        if (PlayerLocation.gameOver)
        {
            if (PlayerLocation.traps[4] &&
                PlayerLocation.traps[2] &&
                PlayerLocation.traps[7] &&
                PlayerLocation.traps[8] &&
                PlayerLocation.traps[5])
            {
                winScreen.enabled = true;
            }
            else
                midWinScreen.enabled = true;

            endCamera.enabled = true;
        }
    }
}
