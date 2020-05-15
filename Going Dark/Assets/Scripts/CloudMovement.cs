/*CloudMovement.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * This script makes the clouds move on the various scenes at a sconstant rate.
 * 
 * Input:
 * How fast the clouds should move.
 * 
 * Output:
 * The cloud is moved across the screen.
 * 
 */

//BEGIN code from Zachary Combs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{

    public float cloudMovementSpeed;


    void Start()
    {
        transform.position -= new Vector3(cloudMovementSpeed *  10f, 0f, 0f);
    }
    void Update()
    {
        transform.position -= new Vector3(cloudMovementSpeed, 0f, 0f);
    }

    //END code from Zachary Combs

}
