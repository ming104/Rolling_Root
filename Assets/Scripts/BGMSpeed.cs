using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSpeed : MonoBehaviour
{
    public float a;
    public AudioSource BGM;
    public AudioSource whyGame;
    
    void Start()
    {
        BGM.volume = PlayerPrefs.GetFloat("bgmSoundVolume");
        whyGame.volume = PlayerPrefs.GetFloat("sfxSoundVolume");
    }
    // Update is called once per frame
    void Update()
    {
        if (PlayManager.Instance.RootDie == true)
        {
            BGM.Stop();
        }
        a += 0.01f;
        if(a > 20)
        {
            BGM.pitch += 0.02f;
            a = 0;
        }
    }
}
