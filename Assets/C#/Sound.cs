using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip audioJump;

    AudioSource audioSource;

    void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    void PlaySound()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
        }
    }
}
