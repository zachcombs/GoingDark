/*LevelSelectMenu.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * This script is used as the main driver for the level selection screens.
 * It contains various methods that are called when buttons are clicked 
 * which will navigate you to other scenes.
 * 
 * Input:
 * Buttons so that you can activate them once the previous level has been cleared.
 * 
 * Output:
 * Navigation to other scenes.
 * More levels to play.
 * 
 */

//BEGIN code from Zachary Combs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public GameObject level2Button;
    public GameObject level3Button;

    public void Awake()
    {
        for (int i = 2; i <= LevelLocker.Instance.level; i++)
        {
            /*
            levelNum = GameObject.Find("Level " + i.ToString() + " Button");
            Debug.Log(levelNum);
            if (!(levelNum.activeSelf))
            {
                Debug.Log("Level" + i + "is inactive");
                levelNum.SetActive(true);
            }
            */
            if(i == 2 && !(level2Button.activeSelf))
            {
                level2Button.SetActive(true);
            }
            if( i == 3 && !(level3Button.activeSelf))
            {
                level3Button.SetActive(true);
            }
        }
    }

    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Level1()
    {
        
        if(LevelLocker.Instance.level == 1)
        {
            LevelLocker.Instance.level++;
        }
        
        SceneManager.LoadScene("Level 1");
    }

    public void Level2()
    {
        
        if (LevelLocker.Instance.level == 2)
        {
            LevelLocker.Instance.level++;
        }
        
        SceneManager.LoadScene("Level 2");
    }

    public void Level3()
    {
        
        if (LevelLocker.Instance.level == 3)
        {
            LevelLocker.Instance.level++;
        }
        
        SceneManager.LoadScene("Level 3");
    }

    public void GoToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void NextLevel()
    {
        LevelLocker.Instance.level++;
        SceneManager.LoadScene(LevelLocker.Instance.level);
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GotToLevelSelectOnLoss()
    {
        SceneManager.LoadScene("LevelSelect");
        LevelLocker.Instance.level--;
    }

    //END code from Zachary Combs

}
