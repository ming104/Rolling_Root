using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayManager : MonoBehaviour
{
    public Text score;

    public Text bestScore;

    public Text killLog;

    public Text jumpCountText;
    
    public void OnEnable()
    {
        score.text = $"Score : {Score.score}";
        if (PlayerPrefs.GetInt("NomalBestScore") < Score.score)
        {
            GetComponent<Text>().text = "New Best!";
        }
        else
        {
            GetComponent<Text>().text = "Best : " + PlayerPrefs.GetInt("NomalBestScore");
        }
        //score.text = $"BestScore : {Score.score}";
    }

    public void ReGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
