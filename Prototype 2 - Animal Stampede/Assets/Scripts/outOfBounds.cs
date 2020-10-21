using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    public float topBounds = 35f;
    public float lowerBounds = -15f;
    
    void Start()
    {
    Time.timeScale = 1;
    }

// Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
