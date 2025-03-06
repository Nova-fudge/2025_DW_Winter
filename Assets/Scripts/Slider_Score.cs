using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Slider_Score : MonoBehaviour
{
    public Slide_Rotator board;
    public List<Slide_Target> target;
    public TextMeshProUGUI movesDisplay;

    public float moveTarget;
    public float movesUsed;
    public List<bool> targetsHit;
    float hitCount;
    public bool allHit = false;

    public Canvas winScreen;
    public TextMeshProUGUI winBarks;

    void Start()
    {
        winScreen.enabled = false;
        winBarks.enabled = false;
    }

    void Update()
    {
        movesUsed = board.movesUsed;
        for (int i = 0; i < 6; i++)
        {
            hitCount++;
            targetsHit[i] = target[i].amHit;
            if (!targetsHit[i])
                hitCount = 0;
        }

        //WIN CONDITION HERE.
        if (hitCount > 5)
        {
            winScreen.enabled = true;
            winBarks.enabled = true;
            allHit = true;
            board.puzzleSolved = true;
            if (movesUsed == moveTarget - 3)
                winBarks.text = "SUCCESS! PERFECT SCORE!";
            else if (movesUsed == moveTarget - 2)
                winBarks.text = "Great work! Nicely done!";
            else if (movesUsed == moveTarget - 1 || movesUsed == moveTarget)
                winBarks.text = "Good job!";
            else if (movesUsed > moveTarget)
                winBarks.text = "You solved the puzzle.";
        }

        movesDisplay.text = "Moves used: " + movesUsed.ToString();
    }
}
