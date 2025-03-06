using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Glyph_Selector : MonoBehaviour
{
    public List<Sprite> glyphList;
    public List<Image> glyphDisplay;
    public List<int> currentIndex;

    void Start()
    {
        glyphDisplay[0].sprite = glyphList[currentIndex[0]];
        glyphDisplay[1].sprite = glyphList[currentIndex[1]];
        glyphDisplay[2].sprite = glyphList[currentIndex[2]];
        glyphDisplay[3].sprite = glyphList[currentIndex[3]];
        glyphDisplay[4].sprite = glyphList[currentIndex[4]];
        glyphDisplay[5].sprite = glyphList[currentIndex[5]];
        glyphDisplay[6].sprite = glyphList[currentIndex[6]];
    }

    public void nextImage(int index)
    {
        if (currentIndex[index] == glyphList.Count - 1)
            currentIndex[index] = -1;
        currentIndex[index] += 1;
        glyphDisplay[index].sprite = glyphList[currentIndex[index]];
    }

    public void previousImage(int index)
    {
        if (currentIndex[index] == 0)
            currentIndex[index] = glyphList.Count;
        currentIndex[index] -= 1;
        glyphDisplay[index].sprite = glyphList[currentIndex[index]];
    }
}
