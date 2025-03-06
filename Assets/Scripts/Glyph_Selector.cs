using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Glyph_Selector : MonoBehaviour
{
    public List<Sprite> glyphList;
    public Image glyphDisplay;

    int index = 0;

    void Start()
    {
        glyphDisplay.sprite = glyphList[index];
    }

    public void nextImage()
    {
        if (index == glyphList.Count - 1)
            index = -1;
        index += 1;
        glyphDisplay.sprite = glyphList[index];
    }

    public void previousImage()
    {
        if (index == 0)
            index = glyphList.Count;
        index -= 1;
        glyphDisplay.sprite = glyphList[index];
    }
}
