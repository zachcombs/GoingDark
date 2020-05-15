/*SettingsMenu.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * This script is used for the slider in the settings menu to manipulate
 * the audio for the entire game.
 * 
 * Input:
 * An audiomixer.
 * 
 * Output:
 * A change in the volume level of the audiomixer.
 * 
 */

//BEGIN code from Zachary Combs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audiomixer;

    public void SetVolume (float volume)
    {
        audiomixer.SetFloat("volume", volume);
    }

    //END code from Zachary Combs
}
