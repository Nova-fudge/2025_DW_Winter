using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Glyph_Selector : MonoBehaviour
{
    public List<Texture> glyphList;
    public RawImage glyphDisplay;

    int imageID = 0;

    void Start()
    {
        glyphDisplay.texture = glyphList[imageID];
    }

    public void nextImage()
    {
        if (imageID == glyphList.Count - 1)
            imageID = -1;
        imageID += 1;
        glyphDisplay.texture = glyphList[imageID];
    }

    public void previousImage()
    {
        if (imageID == 0)
            imageID = glyphList.Count;
        imageID -= 1;
        glyphDisplay.texture = glyphList[imageID];
    }
}
