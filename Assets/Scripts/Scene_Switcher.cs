using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Switcher : MonoBehaviour
{
    public void GoToMaze()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("Maze");
    }
    
    public void GoToSliderPuzzle()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("Slide_Puzzle");
    }

    public void GoToCombatPuzzle()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("Combat_Puzzle");
    }

    public void GoToCipherPuzzle()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("Glyph_Puzzle");
    }

    public void GoToWirePuzzle()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("Wire_Puzzle");
    }

    public void GoToWebPuzzle()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("Web_Puzzle");
    }

    public void SaveLocation(Transform currentLocation)
    {
        PlayerLocation.previousPlayerTransform = currentLocation;
    }
    public Transform LoadLocation()
    {
        Transform currentLocation;
        currentLocation = PlayerLocation.previousPlayerTransform;
        return currentLocation;
    }
}
