using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip coinSound;
    static AudioSource audioSrc;
    void Start()
    {
        coinSound = Resources.Load<AudioClip>("coinSound");
        audioSrc = GetComponent<AudioSource>();
    }

    // change volume of the sound
    public void SetVolumeTo(int volume){
        audioSrc.volume = volume;

    }

    
}
