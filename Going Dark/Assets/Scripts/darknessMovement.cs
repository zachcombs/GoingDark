/*darknessMovement.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * When the player is moving, increase the scale of the object which in
 * this case is an inverted circle. By increasing the scale, the inner circle
 * becomes bigger and allows the player to see more.
 * When the player stands still, the darkness' scale increases.
 * The darkness can't go past a certain threshold with regards to the upper and lower
 * bounds set for the scale.
 * 
 * Input:
 * How fast the darkness should move
 * Previous location of the player in order to check if the player's location had
 * changed.
 * 
 * Output:
 * A growing or shrinking darkness.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darknessMovement : MonoBehaviour
{
    public float scaleSpeed;
    private Vector3 prevLoc;
    private Vector3 temp;
    private int wait;

    void Start()
    {
        prevLoc =  transform.position;
    }

    
    void FixedUpdate()
    {

        //If the player is moving more than 0.1 units in the -x or +x direction 
        //(Some surfaces aren't prefectly flat so there are microadjustments to the position due to sliding that need to be accounted for)
        if (transform.position.x - prevLoc.x > 0.1 || -1 * transform.position.x + prevLoc.x > 0.1)
        {
            //Set Vector3 temp to what the descale would be
            temp = transform.localScale -= new Vector3(scaleSpeed, scaleSpeed);
            //Check to see if the descale would go below the minimum threshold for scale
            if(temp.x < 10f && temp.y < 10f)
            {
                transform.localScale += new Vector3(scaleSpeed, scaleSpeed);
            }
            if (temp.x > 4f && temp.y > 4f)
            {
                transform.localScale -= new Vector3(scaleSpeed, scaleSpeed);
            }
           
        } else //The player is not moving
        {
            //Set Vector3 temp to what the scale would be
            temp = transform.localScale += new Vector3(scaleSpeed, scaleSpeed);
            //Check to see if the scale would go above the maximum threshold for scale
            if (temp.x > 400f && temp.y > 400f)
            {
                transform.localScale -= new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
            } if(temp.x < 400f && temp.y < 400f)
            {
                transform.localScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
            }
        }
        prevLoc = transform.position;
    }

    
}
