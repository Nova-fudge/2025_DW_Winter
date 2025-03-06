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

    // Update is called once per frame
    void Update()
    {
        topCol1 = cardSpace[0].HP - cardSpace[1].Damage;
        topCol2 = cardSpace[2].HP - cardSpace[3].Damage;
        topCol3 = cardSpace[4].HP - cardSpace[5].Damage;
        topCol4 = cardSpace[6].HP - cardSpace[7].Damage;

        botCol1 = cardSpace[1].HP - cardSpace[0].Damage;
        botCol2 = cardSpace[3].HP - cardSpace[2].Damage;
        botCol3 = cardSpace[5].HP - cardSpace[4].Damage;
        botCol4 = cardSpace[7].HP - cardSpace[6].Damage;

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
            Debug.Log("SUCCESS");
    }
}
