using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    //find player
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    //speed and destroy if it falls off
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);

        if(transform.position.y < -10) 
        { Destroy(gameObject); }
    }
}
