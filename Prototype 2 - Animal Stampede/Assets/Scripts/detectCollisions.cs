﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void onTriggerEnter(Collider other)
    {
    //destroy this object
        Destroy(gameObject);
        
    //destroy other object that this object is colliding with
        Destroy(other.gameObject);
    }
}