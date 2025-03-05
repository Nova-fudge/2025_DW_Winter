using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires_Draw : MonoBehaviour
{
    public Transform startPos;
    public Transform wireEnd;

    LineRenderer lr;

    private void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        lr.SetPosition(0, startPos.position);
        lr.SetPosition(1, wireEnd.position);
    }
}
