using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiDestroyScript : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        this.gameObject.transform.position = player.transform.position;
    }
}
