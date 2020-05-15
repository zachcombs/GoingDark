/*LevelLocker.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * This script is based around the idea of a singleton and is used to persist
 * data, in this case levels completed, so that when you switch scenes you don't
 * lose the data  concerning your progress.
 * 
 * Input:
 * N/A
 * 
 * Output:
 * A gameobject that persists even when switching scenes.
 * 
 */

//BEGIN code from Zachary Combs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLocker : MonoBehaviour
{
    public static LevelLocker Instance { get; private set; }

    public int level;

    private void Awake()
    {
        if(level == 0)
        {
            level++;
        }
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    //END code from Zachary Combs

}
