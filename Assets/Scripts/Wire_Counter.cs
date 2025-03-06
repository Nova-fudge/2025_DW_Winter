using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Wire_Counter : MonoBehaviour
{
    public List<Transform> wire;
    public List<Transform> end;
    public List<float> targetVals;
    public List<TextMeshProUGUI> targetText;

    float wire1;
    float wire2;
    float wire3;
    float wire4;
    float pointTotal;

    int chosenTarget;
    public float pointTarget;

    public bool allConnected = false;

    public Slider sliderFill;

    private void Start()
    {
        chosenTarget = Random.Range(0, 3);
        pointTarget = targetVals[chosenTarget];
        targetText[chosenTarget].color = Color.green;
    }

    void Update()
    {
        allConnected = true;

        //Wire 1 connections
        if (wire[0].position == end[0].position)
            wire1 = 3;
        else if (wire[0].position == end[1].position)
            wire1 = 2;
        else if (wire[0].position == end[2].position)
            wire1 = 1;
        else if (wire[0].position == end[3].position)
            wire1 = 4;
        else
        {
            wire1 = 0;
            allConnected = false;
        }

        //Wire 2 connections
        if (wire[1].position == end[0].position)
            wire2 = 1;
        else if (wire[1].position == end[1].position)
            wire2 = 3;
        else if (wire[1].position == end[2].position)
            wire2 = 4;
        else if (wire[1].position == end[3].position)
            wire2 = 2;
        else
        {
            wire2 = 0;
            allConnected = false;
        }

        //Wire 3 connections
        if (wire[2].position == end[0].position)
            wire3 = 2;
        else if (wire[2].position == end[1].position)
            wire3 = 1;
        else if (wire[2].position == end[2].position)
            wire3 = 3;
        else if (wire[2].position == end[3].position)
            wire3 = 4;
        else
        {
            wire3 = 0;
            allConnected = false;
        }

        //Wire 4 connections
        if (wire[3].position == end[0].position)
            wire4 = 4;
        else if (wire[3].position == end[1].position)
            wire4 = 1;
        else if (wire[3].position == end[2].position)
            wire4 = 2;
        else if (wire[3].position == end[3].position)
            wire4 = 3;
        else
        {
            wire4 = 0;
            allConnected = false;
        }

        totalPoints();
    }

    public void totalPoints()
    {
        pointTotal = wire1 + wire2 + wire3 + wire4;
        sliderFill.value = pointTotal;

        //WIN CONDITION HERE.
        if (allConnected && pointTotal == pointTarget)
            Debug.Log("SUCCESS");
    }
}
