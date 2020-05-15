/*EndLevel.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * This script checks to see if the player has reached the end of the level.
 * And if so, a win UI shows up for the player to navigate.
 * 
 * Input:
 * A player to see if the player has reached the end of the level.
 * A winUI to enable once the win condition has been reached.
 * A timer UI to disable to clear up the screen when you win.
 * 
 * Output:
 * A winUI pops up if you win, allowing you to go to the next level or chose a
 * different level.
 * 
 */

//BEGIN code from Zachary Combs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public GameObject player;
    public GameObject winUI;
    public GameObject timer;
    public GameObject endOfLevel;

    // Update is called once per frame
    void Update()
    {
        CheckEndOfLevel();
    }

    void CheckEndOfLevel()
    {
        if (player.transform.position.x > endOfLevel.transform.position.x)
        {
            timer.SetActive(false);
            winUI.SetActive(true);
        }
    }

    //BEGIN code from Zachary Combs

}
