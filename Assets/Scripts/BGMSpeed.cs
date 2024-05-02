using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSpeed : MonoBehaviour
{
    public float a;
    public AudioSource BGM;

    // Update is called once per frame
    void Update()
    {
        a += 0.01f;
        if(a > 20)
        {
            BGM.pitch += 0.02f;
            a = 0;
        }
    }
}
