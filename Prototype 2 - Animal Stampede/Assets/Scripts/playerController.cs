﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour

{
    public float horizontalInput;
    public float speed = 10f;
//boundries
    public float xRange = 20;
    
    public GameObject foodProjectile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
    //constrains players movement to the left
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    //contrains players movement to the right
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
