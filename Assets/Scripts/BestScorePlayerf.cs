using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestScorePlayerf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("bestscore"))
        {
            PlayerPrefs.SetInt("bestscore", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
