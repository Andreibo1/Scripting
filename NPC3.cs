using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        print("Lives:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
