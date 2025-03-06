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
            allHit = true;
            board.puzzleSolved = true;
            if (movesUsed == moveTarget - 3)
                Debug.Log("SUCCESS! PERFECT SCORE!");
            else if (movesUsed == moveTarget - 2)
                Debug.Log("Great work! Nicely done!");
            else if (movesUsed == moveTarget - 1 || movesUsed == moveTarget)
                Debug.Log("Good job!");
            else if (movesUsed > moveTarget)
                Debug.Log("You solved the puzzle.");
        }

        movesDisplay.text = "Moves used: " + movesUsed.ToString();
    }
}
