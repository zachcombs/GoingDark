/*MainMenuSelect.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * This is the main driver class for the opening screen to the game.
 * It essentially serves the same functionality as the LevelSelectMenu script.
 * I just created the other because I forgot this one existed, but this does
 * have seperate functions from the other script.
 * 
 * Input:
 * Buttons to trigger the functions.
 * 
 * Output:
 * Redirection to other scenes when those buttons are triggered.
 * 
 */

//BEGIN code from Zachary Combs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSelect : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject mainMenu;

    public void SelectPlay()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void SelectQuit()
    {
        Application.Quit();
    }

    public void SelectOptions()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void SelectBack()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    //END code from Zachary Combs

}
