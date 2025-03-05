using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Web_Randomizer : MonoBehaviour
{
    public List<Transform> cubes;
    public List<Transform> startPos;

    public int puzzleNum;

    void Start()
    {
        puzzleNum = Random.Range(1, 5);

        if (puzzleNum == 1)
        {
            cubes[0].position = startPos[3].position;
            cubes[1].position = startPos[5].position;
            cubes[2].position = startPos[0].position;
            cubes[3].position = startPos[4].position;
            cubes[4].position = startPos[2].position;
            cubes[5].position = startPos[6].position;
            cubes[6].position = startPos[1].position;
            cubes[7].position = startPos[7].position;
        }

        if (puzzleNum == 2)
        {
            cubes[0].position = startPos[1].position;
            cubes[1].position = startPos[4].position;
            cubes[2].position = startPos[0].position;
            cubes[3].position = startPos[7].position;
            cubes[4].position = startPos[3].position;
            cubes[5].position = startPos[6].position;
            cubes[6].position = startPos[5].position;
            cubes[7].position = startPos[2].position;
        }

        if (puzzleNum == 3)
        {
            cubes[0].position = startPos[4].position;
            cubes[1].position = startPos[1].position;
            cubes[2].position = startPos[6].position;
            cubes[3].position = startPos[2].position;
            cubes[4].position = startPos[7].position;
            cubes[5].position = startPos[3].position;
            cubes[6].position = startPos[5].position;
            cubes[7].position = startPos[0].position;
        }

        if (puzzleNum == 4)
        {
            cubes[0].position = startPos[3].position;
            cubes[1].position = startPos[6].position;
            cubes[2].position = startPos[1].position;
            cubes[3].position = startPos[7].position;
            cubes[4].position = startPos[2].position;
            cubes[5].position = startPos[4].position;
            cubes[6].position = startPos[0].position;
            cubes[7].position = startPos[5].position;
        }
    }
}
