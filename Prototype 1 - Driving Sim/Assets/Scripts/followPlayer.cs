using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,5,-7);
    

    // Update is called once per frame
    void Update()
    {
        //makes camera match players movement / position
        transform.position = player.transform.position + offset;
    }
}
