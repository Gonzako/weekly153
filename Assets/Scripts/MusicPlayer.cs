using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public bool in_game; //in_game is a boolean that should be called from a game controller
    public AudioSource music;

    // Update is called once per frame
    void Start()
    {
        if (in_game && !music.isPlaying)
        {
            music.Play();
        }
        else if(!in_game && music.isPlaying)
        {
            music.Stop();
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
