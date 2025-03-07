using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Web_Check : MonoBehaviour
{
    public Transform cube_1;
    public Transform cube_2;
    public Transform cube_3;
    public Transform cube_4;
    public Transform cube_5;
    public Transform cube_6;
    public Transform cube_7;
    public Transform cube_8;

    public LineRenderer lineMat;
    public Material happyLine;

    public Canvas winScreen;
    bool puzzleSolved = false;
    public Camera trapCamera;

    private void Start()
    {
        winScreen.enabled = false;
    }

    void Update()
    {
        Vector3 oneToTwo = cube_1.position - cube_2.position;
        Vector3 twoToThree = cube_2.position - cube_3.position;
        Vector3 threeToFour = cube_3.position - cube_4.position;
        Vector3 fourToFive = cube_4.position - cube_5.position;
        Vector3 fiveToSix = cube_5.position - cube_6.position;
        Vector3 sixToSeven = cube_6.position - cube_7.position;
        Vector3 sevenToEight = cube_7.position - cube_8.position;
        Vector3 eightToOne = cube_8.position - cube_1.position;

        //WIN CONDITION HERE.
        if (
            oneToTwo.magnitude < 5 &&
            twoToThree.magnitude < 5 &&
            threeToFour.magnitude < 5 &&
            fourToFive.magnitude < 5 &&
            fiveToSix.magnitude < 5 &&
            sixToSeven.magnitude < 5 &&
            sevenToEight.magnitude < 5 &&
            eightToOne.magnitude < 5)
        {
            lineMat.material = happyLine;
            winScreen.enabled = true;
            if (puzzleSolved)
                return;
            puzzleSolved = true;
            PlayerLocation.DoneWeb();
        }
    }
}
