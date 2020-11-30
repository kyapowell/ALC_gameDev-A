using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    private PlayerController playerControllerScript;
    private float leftBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
       //if game not over move left
    
       if (playerControllerScript.gameOver == false)
       {
           transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
       } 

       //if object goes offscreen destroy it
       if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
       {
           Destroy(gameObject);
       }

    }
}
