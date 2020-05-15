/*PlayerMovement.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * This class is the driver class for the player. Most player interactions
 * with the environment are controller through this. This script checks for
 * various collisions, it plays sounds, and it moves the player as well.
 * This class is an extenstion of the CharacterController script.
 * 
 * Input:
 * Anything the player can interact with.
 * Music to play once the player interacts with something.
 * UI's to enable once the playes interacts with something.
 * A player object to see what the player is doing.
 * Various gameObjects which are place holders for positions the player might
 * move to in various levels.
 * 
 * Output:
 * Player interaction with it's environment.
 * Movement.
 * Collision triggers.
 * Activation and deactivation of various UI elements.
 * 
 */

//BEGIN code from Zachary Combs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    public GameObject topTeleEndLoc;
    public GameObject bottomTeleEndLoc;
    public GameObject player;
    private Vector3 lastLoc;
    public AudioSource oohSource;
    public AudioSource teleportSource;
    public AudioSource hourglassSource;
    public GameObject timerUI;
    public GameObject loseUI;
    private bool isDisabled;
    private Vector3 startPos;

    // Update is called once per frame
    void Start()
    {
        startPos = player.transform.position;
        isDisabled = false;
    }

    void Update()
    {
        if(isDisabled == false)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }

            if (Input.GetButtonDown("Crouch"))
            {
                crouch = true;
            }
            else if (Input.GetButtonUp("Crouch"))
            {
                crouch = false;
            }
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Hourglass")
        {
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == "oob")
        {
            isDisabled = true;
            player.GetComponent<SpriteRenderer>().enabled = false;
            timerUI.SetActive(false);
            loseUI.SetActive(true);
            PlaySound();
        }
        if (coll.gameObject.tag == "beginLevel")
        {
            player.transform.position = startPos;
        }
        if (coll.gameObject.tag == "bottomTeleporter")
        {
            teleportSource.Play();
            lastLoc = player.transform.position;
            player.transform.position = new Vector3(5, 70, 0);
        }
        if (coll.gameObject.tag == "topTeleporter")
        {
            teleportSource.Play();
            player.transform.position = lastLoc + new Vector3(10, 0, 0);
        }
        if (coll.gameObject.tag == "hourglass")
        {
            hourglassSource.Play();
        }
    }

    void PlaySound()
    {
        oohSource.enabled = true;
        oohSource.Play();
    }

    //END code from Zachary Combs

}
