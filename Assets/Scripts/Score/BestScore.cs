using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("bestscore")==Score.score) GetComponent<Text>().text = "New Best!";
        else GetComponent<Text>().text = "Best : " + PlayerPrefs.GetInt("bestscore");
    }
}
