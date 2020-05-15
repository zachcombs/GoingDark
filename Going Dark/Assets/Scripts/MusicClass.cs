/*MusicClass.cs
 * 
 * Zachary Combs
 * zcombs1
 * CSc 4821
 * Project Script
 * 
 * Description:
 * This class is another singleton instance but this time it is used 
 * to play the music across scenes. It only allows this music class to 
 * be created and it will destroy the others while persisting this one.
 * 
 * Input:
 * Music to persist.
 * 
 * Output:
 * A persistant object that plays the music when the game starts.
 * 
 */

//BEGIN code from Zachary Combs

using UnityEngine;

public class MusicClass : MonoBehaviour
{
    private AudioSource _audioSource;
    public static MusicClass Instance
    {
        get; private set;
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }

    //END code from Zachary Combs

}