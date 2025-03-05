using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Combat_Card : MonoBehaviour
{
    public float HP;
    public float Damage;
    public TextMeshPro HPtext;
    public TextMeshPro DMGtext;

    private void Start()
    {
        HPtext.text = HP.ToString();
        DMGtext.text = Damage.ToString();
    }
}
