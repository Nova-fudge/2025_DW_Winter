using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Glyph_Selector : MonoBehaviour
{
    public List<Sprite> glyphList;
    public List<Image> glyphDisplay;
    public List<int> currentIndex;

    public Canvas winScreen;

    bool puzzleSolved = false;
    public Camera trapCamera;

    public AudioSource audio;

    void Start()
    {
        winScreen.enabled = false;
        glyphDisplay[0].sprite = glyphList[currentIndex[0]];
        glyphDisplay[1].sprite = glyphList[currentIndex[1]];
        glyphDisplay[2].sprite = glyphList[currentIndex[2]];
        glyphDisplay[3].sprite = glyphList[currentIndex[3]];
        glyphDisplay[4].sprite = glyphList[currentIndex[4]];
        glyphDisplay[5].sprite = glyphList[currentIndex[5]];
        glyphDisplay[6].sprite = glyphList[currentIndex[6]];
    }

    private void Update()
    {
        //WIN CONDITION HERE.
        if (currentIndex[0] == 18 &&
            currentIndex[1] == 4 &&
            currentIndex[2] == 19 &&
            currentIndex[3] == 19 &&
            currentIndex[4] == 17 &&
            currentIndex[5] == 0 &&
            currentIndex[6] == 15)
        {
            winScreen.enabled = true;

            if (puzzleSolved)
                return;
            puzzleSolved = true;
            PlayerLocation.DoneGlyphs();
        }
    }

    public void nextImage(int index)
    {
        audio.Play();
        if (currentIndex[index] == glyphList.Count - 1)
            currentIndex[index] = -1;
        currentIndex[index] += 1;
        glyphDisplay[index].sprite = glyphList[currentIndex[index]];
    }

    public void previousImage(int index)
    {
        audio.Play();
        if (currentIndex[index] == 0)
            currentIndex[index] = glyphList.Count;
        currentIndex[index] -= 1;
        glyphDisplay[index].sprite = glyphList[currentIndex[index]];
    }
}
