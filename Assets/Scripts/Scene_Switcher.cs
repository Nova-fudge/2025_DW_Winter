using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Switcher : MonoBehaviour
{
    public void GoToMaze()
    {
        SceneManager.LoadScene("Maze");
    }
    
    public void GoToSliderPuzzle()
    {
        SceneManager.LoadScene("Slide_Puzzle");
    }

    public void GoToCombatPuzzle()
    {
        SceneManager.LoadScene("Combat_Puzzle");
    }

    public void GoToCipherPuzzle()
    {
        SceneManager.LoadScene("Glyph_Puzzle");
    }

    public void GoToWirePuzzle()
    {
        SceneManager.LoadScene("Wire_Puzzle");
    }

    public void GoToWebPuzzle()
    {
        SceneManager.LoadScene("Web_Puzzle");
    }
}
