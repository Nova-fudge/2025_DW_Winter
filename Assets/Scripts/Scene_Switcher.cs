using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Switcher : MonoBehaviour
{

    public bool doneSlider;
    public bool doneCombat;
    public bool doneCipher;
    public bool doneWire;
    public bool doneWeb;

    public GameObject boxCollider;
    public GameObject boxCollider1;
    public GameObject boxCollider2;
    public GameObject boxCollider3;
    public GameObject boxCollider4;
    public GameObject boxCollider5;
    public void GoToMaze()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("Maze");
    }
    
    public void GoToSliderPuzzle()
    {
        if (PlayerLocation.sliderDone)
            return;

        PlayerLocation.enterExitTrap();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        doneSlider = true;
        
        SceneManager.LoadScene("Slide_Puzzle");
    }

    public void GoToCombatPuzzle()
    {
        if (PlayerLocation.combatDone)
            return;

        PlayerLocation.enterExitTrap();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        doneCombat = true;
        SceneManager.LoadScene("Combat_Puzzle");
    }

    public void GoToCipherPuzzle()
    {
        if (PlayerLocation.glyphsDone)
            return;

        PlayerLocation.enterExitTrap();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        doneCipher = true;
        SceneManager.LoadScene("Glyph_Puzzle");
    }

    public void GoToWirePuzzle()
    {
        if (PlayerLocation.wiresDone)
            return;

        PlayerLocation.enterExitTrap();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        doneWire = true;
        SceneManager.LoadScene("Wire_Puzzle");
    }

    public void GoToWebPuzzle()
    {
        if (PlayerLocation.webDone)
            return;

        PlayerLocation.enterExitTrap();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        doneWeb = true;
        SceneManager.LoadScene("Web_Puzzle");
    }
}
