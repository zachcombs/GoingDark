/*Timer.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * This script controls the timer you see while playing the levels.
 * It ticks every second by taking the mod of the float value, deltaTime, by 1
 * once deltaTime is over 1 second.
 * 
 * Input:
 * Text objects
 * Various numbers to calculate when a second has passed when this script is running.
 * 
 * Output:
 * A text object that changes based on how many more seconds are left in the countdown timer.
 * 
 */

//BEGIN code from Zachary Combs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    //public Text timerText;
    public TextMeshProUGUI textTimer;
    public int timeAllowed;
    public float elapsedTime = 0f;
    int timerCount;
    public bool hourglass;
    public TextMeshProUGUI timeAdded;
    public int timeGiven;

    // Start is called before the first frame update
    void Start()
    {
        hourglass = true;
        textTimer.GetComponent<TextMeshProUGUI>().text = "Time Left" + "\n" + timeAllowed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 1f)
        {
            elapsedTime = elapsedTime % 1f;
            DecreaseTimer();
        }
        if(timeAllowed == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(GameObject.Find("Hourglass") == null && hourglass == true)
        {
            IncreaseTimer(timeGiven);
            hourglass = false;
        }
    }

    void IncreaseTimer(int t)
    {
        timeAllowed += t;
        textTimer.GetComponent<TextMeshProUGUI>().text = "Time Left" + "\n" + timeAllowed.ToString();
    }

    void DecreaseTimer()
    {
        timeAllowed--;
        textTimer.GetComponent<TextMeshProUGUI>().text = "Time Left" + "\n" + timeAllowed.ToString();
    }

    //END code from Zachary Combs

}
