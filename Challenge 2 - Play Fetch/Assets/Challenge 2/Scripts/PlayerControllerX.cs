﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1; //time the player has to wait to fire again
    private float nextFire = 0; //time since start tl player can fire again

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
      //reset nextFire to current time plus fire rate      
            nextFire = Time.time + fireRate; 
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
