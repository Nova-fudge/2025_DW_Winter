using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Combat_Calculator : MonoBehaviour
{
    public List<Combat_Reader> cardSpace;
    public TextMeshPro topText;
    public TextMeshPro botText;

    float topCol1;
    float topCol2;
    float topCol3;
    float topCol4;
    float botCol1;
    float botCol2;
    float botCol3;
    float botCol4;

    float topRow;
    float botRow;

    public float topTarget;
    public float botTarget;

    public Canvas winScreen;

    private void Start()
    {
        winScreen.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cardSpace[1].Damage != 0)
            topCol1 = cardSpace[0].HP - cardSpace[1].Damage;
        else
            topCol1 = 0;
        if (cardSpace[3].Damage != 0)
            topCol2 = cardSpace[2].HP - cardSpace[3].Damage;
        else
            topCol2 = 0;
        if (cardSpace[5].Damage != 0)
            topCol3 = cardSpace[4].HP - cardSpace[5].Damage;
        else
            topCol3 = 0;
        if (cardSpace[7].Damage != 0)
            topCol4 = cardSpace[6].HP - cardSpace[7].Damage;
        else
            topCol4 = 0;

        if (cardSpace[0].Damage != 0)
            botCol1 = cardSpace[1].HP - cardSpace[0].Damage;
        else
            botCol1 = 0;
        if (cardSpace[2].Damage != 0)
            botCol2 = cardSpace[3].HP - cardSpace[2].Damage;
        else
            botCol2 = 0;
        if (cardSpace[4].Damage != 0)
            botCol3 = cardSpace[5].HP - cardSpace[4].Damage;
        else
            botCol3 = 0;
        if (cardSpace[6].Damage != 0)
            botCol4 = cardSpace[7].HP - cardSpace[6].Damage;
        else
            botCol4 = 0;

        topRow = -1 * (topCol1 + topCol2 + topCol3 + topCol4);
        botRow = -1 * (botCol1 + botCol2 + botCol3 + botCol4);

        if (topRow > 0)
            topText.text = topRow.ToString() + "/" + topTarget.ToString();
        else
            topText.text = "0/" + topTarget.ToString();

        if (botRow > 0)
            botText.text = botRow.ToString() + "/" + botTarget.ToString();
        else
            botText.text = "0/" + botTarget.ToString();

        //WIN CONDITION HERE.
        if (topRow == topTarget && botRow == botTarget)
            winScreen.enabled = true;
    }
}
