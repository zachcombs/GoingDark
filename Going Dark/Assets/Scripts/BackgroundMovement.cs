/*BackgroundMovement.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * This script moves the background as the player moves in the direction
 * the player is going. It's supposed to give a "parallax" effect without
 * the multiple layers associated with parallazing.
 * 
 * Input:
 * moveSpeed of background relative to player
 * a previous location of the the player to see if they moved
 * a player and their rigidbody
 * 
 * Output:
 * Moving the background relative to the player by a given moveSpeed
 * 
 */

//BEGIN code from Zachary Combs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    /*
    public GameObject player;
    public Vector3 moveSpeed;
    private Vector3 lastLoc;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
        lastLoc = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if((rb.position.x - lastLoc.x) > 0)
        {
            Debug.Log("Please be weoking");
            transform.position += moveSpeed;
        } else if((rb.position.x - lastLoc.x) < 0)
        {
            Debug.Log("Please be weoking");
            transform.position -= moveSpeed;
        }
        lastLoc = transform.position;
    }
    */

    

    public GameObject player;
    public float moveSpeed;
    private Vector3 prevLoc;
    private Rigidbody2D rb;

    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
        prevLoc = transform.position;
    }


    void FixedUpdate()
    {
        if (rb.position.x - prevLoc.x > 0.1)
        {
            transform.position += new Vector3(moveSpeed, 0, 0);
        }
        else if(-1 * rb.position.x + prevLoc.x > 0.1)
        {
            transform.position -= new Vector3(moveSpeed, 0 , 0);
        }
        prevLoc = rb.position;
    }

    //END code from Zachary Combs
}
