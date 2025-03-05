using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wire_Counter : MonoBehaviour
{
    public List<Transform> wire;
    public List<Transform> end;

    public float wire1;
    public float wire2;
    public float wire3;
    public float wire4;
    public float pointTotal;

    public bool notAllConnected = true;

    public Slider sliderFill;

    void Update()
    {
        notAllConnected = false;

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
            notAllConnected = true;
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
            notAllConnected = true;
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
            notAllConnected = true;
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
            notAllConnected = true;
        }

        totalPoints();
    }

    public void totalPoints()
    {
        pointTotal = wire1 + wire2 + wire3 + wire4;
        sliderFill.value = pointTotal;
    }
}
