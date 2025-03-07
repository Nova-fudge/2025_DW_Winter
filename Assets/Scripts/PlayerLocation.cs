using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation
{
    public Vector3 previousPlayerTransform { get; set; }

    public static bool inTrap = false;

    public static bool sliderDone = false;
    public static bool combatDone = false;
    public static bool webDone = false;
    public static bool wiresDone = false;
    public static bool glyphsDone = false;

    public static int currentIndex = -1;
    public static bool[] traps = new bool[10];


    public static void DoneSlider()
    {
        Debug.Log("slider done");
        sliderDone = true;
    }

    public static void DoneCombat()
    {
        combatDone = true;
    }

    public static void DoneWeb()
    {
        webDone = true;
    }

    public static void DoneWires()
    {
        wiresDone = true;
    }

    public static void DoneGlyphs()
    {
        glyphsDone = true;
    }

    public static void enterExitTrap()
    {
        inTrap = !inTrap;
    }

    public static void chosenTrapNumber(int index)
    {
        currentIndex = index;
    }

    public static void trapPlaced()
    {
        traps[currentIndex] = true;
    }
}
