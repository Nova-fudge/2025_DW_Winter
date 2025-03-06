using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider_Score : MonoBehaviour
{
    public Slide_Rotator board;
    public List<Slide_Target> target;

    public float maxMoves;
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
        if (hitCount > 5 && movesUsed <= maxMoves)
        {
            allHit = true;
            board.puzzleSolved = true;
            if (movesUsed == 12)
                Debug.Log("SUCCESS! PERFECT SCORE!");
            else if (movesUsed == 13)
                Debug.Log("Great work! Nicely done!");
            else if (movesUsed == 14)
                Debug.Log("Good job.");
            else if (movesUsed == 15)
                Debug.Log("You solved the puzzle.");
        }
    }
}
