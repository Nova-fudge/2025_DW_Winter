using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat_Reader : MonoBehaviour
{
    Combat_Card readFloats;
    Combat_Mover cardState;
    public float HP;
    public float Damage;
    public bool placed = false;

    private void OnTriggerStay(Collider card)
    {
        cardState = card.gameObject.GetComponent<Combat_Mover>();
        placed = cardState.placed;

        if (placed)
        {
            Debug.Log("PLACED");
            readFloats = card.gameObject.GetComponent<Combat_Card>();
            HP = readFloats.HP;
            Damage = readFloats.Damage;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        HP = 0;
        Damage = 0;
    }
}
