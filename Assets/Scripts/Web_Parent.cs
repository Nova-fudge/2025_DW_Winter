using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Web_Parent : MonoBehaviour
{
    public Transform cube_1;
    public Transform cube_2;
    public Transform cube_3;
    public Transform cube_4;
    public Transform cube_5;
    public Transform cube_6;
    public Transform cube_7;
    public Transform cube_8;

    bool firstCubeSelected = false;
    bool secondCubeSelected = false;
    public int firstCubeNum;
    public int secondCubeNum;
    public Transform selected1;
    public Transform selected2;
    bool swap = false;

    public List<MeshRenderer> cubeMats;
    public Material selectedMat;
    public Material baseMat;

    void Update()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //Check for the second cube BEFORE the first, to prevent same-frame overlap of cube selection.
        if (Physics.Raycast(mouseRay, out hit) && Input.GetMouseButtonDown(0) && firstCubeSelected && !secondCubeSelected)
        {
            if (hit.transform.position == cube_1.position)
                selectCube2(1);
            if (hit.transform.position == cube_2.position)
                selectCube2(2);
            if (hit.transform.position == cube_3.position)
                selectCube2(3);
            if (hit.transform.position == cube_4.position)
                selectCube2(4);
            if (hit.transform.position == cube_5.position)
                selectCube2(5);
            if (hit.transform.position == cube_6.position)
                selectCube2(6);
            if (hit.transform.position == cube_7.position)
                selectCube2(7);
            if (hit.transform.position == cube_8.position)
                selectCube2(8);

        }

        if (Physics.Raycast(mouseRay, out hit) && Input.GetMouseButtonDown(0) && !firstCubeSelected)
        {
            if (hit.transform.position == cube_1.position)
                selectCube1(1);
            if (hit.transform.position == cube_2.position)
                selectCube1(2);
            if (hit.transform.position == cube_3.position)
                selectCube1(3);
            if (hit.transform.position == cube_4.position)
                selectCube1(4);
            if (hit.transform.position == cube_5.position)
                selectCube1(5);
            if (hit.transform.position == cube_6.position)
                selectCube1(6);
            if (hit.transform.position == cube_7.position)
                selectCube1(7);
            if (hit.transform.position == cube_8.position)
                selectCube1(8);
        }

        if (!swap && firstCubeSelected && secondCubeSelected)
            swapCubes();
    }

    void selectCube1 (int cubeNum)
    {
        //Identify FIRST selected cube number.
        firstCubeNum = cubeNum;
        firstCubeSelected = true;
        if (cubeNum == 1)
            selected1.position = cube_1.position;
        if (cubeNum == 2)
            selected1.position = cube_2.position;
        if (cubeNum == 3)
            selected1.position = cube_3.position;
        if (cubeNum == 4)
            selected1.position = cube_4.position;
        if (cubeNum == 5)
            selected1.position = cube_5.position;
        if (cubeNum == 6)
            selected1.position = cube_6.position;
        if (cubeNum == 7)
            selected1.position = cube_7.position;
        if (cubeNum == 8)
            selected1.position = cube_8.position;

        //-1 because lists count from 0 for some reason.
        cubeMats[firstCubeNum - 1].material = selectedMat;
    }

    void selectCube2(int cubeNum)
    {
        //Identify SECOND selected cube number.
        secondCubeNum = cubeNum;
        secondCubeSelected = true;
        if (cubeNum == 1)
            selected2.position = cube_1.position;
        if (cubeNum == 2)
            selected2.position = cube_2.position;
        if (cubeNum == 3)
            selected2.position = cube_3.position;
        if (cubeNum == 4)
            selected2.position = cube_4.position;
        if (cubeNum == 5)
            selected2.position = cube_5.position;
        if (cubeNum == 6)
            selected2.position = cube_6.position;
        if (cubeNum == 7)
            selected2.position = cube_7.position;
        if (cubeNum == 8)
            selected2.position = cube_8.position;

        //Swap is now ready to activate.
        swap = false;
    }

    void swapCubes()
    {
        //Set the FIRST selected cube to the position of the SECOND selected cube.
        if (firstCubeNum == 1)
            cube_1.position = selected2.position;
        if (firstCubeNum == 2)
            cube_2.position = selected2.position;
        if (firstCubeNum == 3)
            cube_3.position = selected2.position;
        if (firstCubeNum == 4)
            cube_4.position = selected2.position;
        if (firstCubeNum == 5)
            cube_5.position = selected2.position;
        if (firstCubeNum == 6)
            cube_6.position = selected2.position;
        if (firstCubeNum == 7)
            cube_7.position = selected2.position;
        if (firstCubeNum == 8)
            cube_8.position = selected2.position;

        //Set the SECOND selected cube to the position of the FIRST selected cube.
        if (secondCubeNum == 1)
            cube_1.position = selected1.position;
        if (secondCubeNum == 2)
            cube_2.position = selected1.position;
        if (secondCubeNum == 3)
            cube_3.position = selected1.position;
        if (secondCubeNum == 4)
            cube_4.position = selected1.position;
        if (secondCubeNum == 5)
            cube_5.position = selected1.position;
        if (secondCubeNum == 6)
            cube_6.position = selected1.position;
        if (secondCubeNum == 7)
            cube_7.position = selected1.position;
        if (secondCubeNum == 8)
            cube_8.position = selected1.position;

        //Swap has been completed.
        swap = true;
        //Cubes are no longer selected.
        firstCubeSelected = false;
        secondCubeSelected = false;
        //-1 because lists count from 0 for some reason.
        cubeMats[firstCubeNum - 1].material = baseMat;
    }
}
