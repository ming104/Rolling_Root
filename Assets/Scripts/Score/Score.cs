using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int score = 0;

    public static int Bestscore;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "" + score.ToString();
        if (PlayerPrefs.GetInt("bestscore") < score)
        {
            GetComponent<Text>().color = new Color(1f, 0f, 0f);
        }
        if (SceneManager.GetActiveScene().name == "GameOverScene")
        {
            GetComponent<Text>().color = new Color(1f, 1f, 1f);
        }
    }
}
