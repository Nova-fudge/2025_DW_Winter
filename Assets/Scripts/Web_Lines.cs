using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Web_Lines : MonoBehaviour
{
    public Transform cube_1;
    public Transform cube_2;
    public Transform cube_3;
    public Transform cube_4;
    public Transform cube_5;
    public Transform cube_6;
    public Transform cube_7;
    public Transform cube_8;

    LineRenderer lr;

    private void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        lr.SetPosition(0, cube_1.position);
        lr.SetPosition(1, cube_2.position);
        lr.SetPosition(2, cube_3.position);
        lr.SetPosition(3, cube_4.position);
        lr.SetPosition(4, cube_5.position);
        lr.SetPosition(5, cube_6.position);
        lr.SetPosition(6, cube_7.position);
        lr.SetPosition(7, cube_8.position);
        lr.SetPosition(8, cube_1.position);
    }
}
