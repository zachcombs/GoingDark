/*LevelLoader.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * This script is used to change persisting level data. If you played a level
 * and completed it, the level count will go up, allowing you to see more levels
 * in the level selection screen.
 * 
 * Input:
 * Buttons to activate when their respective levels have been cleared.
 * 
 * Output:
 * An updated count of the levels completed.
 * 
 */

//BEGIN code from Zachary Combs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public GameObject level2Button;
    public GameObject level3Button;

    void Start()
    {

        if(LevelLocker.Instance.level == 2)
        {
            level2Button.SetActive(true);
        }

        if (LevelLocker.Instance.level == 3)
        {
            level3Button.SetActive(true);
        }
    }

    //END code from Zachary Combs

}
