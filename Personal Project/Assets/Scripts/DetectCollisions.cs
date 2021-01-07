using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public bool gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true)
        {
            Debug.Log("Game Over!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //destroy this object
        Destroy(gameObject);
        gameOver = true;

        //destroy other gameobject
        Destroy(other.gameObject);
    
    }
}
