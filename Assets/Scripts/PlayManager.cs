using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayManager : MonoBehaviour
{
    private static PlayManager instance = null;

    private void Awake()
    {
        if (null == instance)
        {
            instance = this;
        }
    }

    public static PlayManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }

            return instance;
        }
    }

    public GameObject rootDiePanel;
    
    public int killType;
    
    public Text score;

    public Text bestScore;

    public Text killLog;

    public Text jumpCountText;

    public bool RootDie;
    
    public AudioSource rootDie;
    public AudioClip rootDieSound;

    private void Start()
    {
        rootDiePanel.SetActive(false);
        Time.timeScale = 1f;
        RootDie = false;
        rootDie.volume = PlayerPrefs.GetFloat("sfxSoundVolume");
    }

    public void RootdiePanelOn()
    {
        RootDie = true;
        rootDie.PlayOneShot(rootDieSound);
        rootDiePanel.SetActive(true);
        Time.timeScale = 0f;
        
        score.text = $"Score : {Score.score}";
        if (PlayerPrefs.GetInt("NomalBestScore") < Score.score)
        {
            bestScore.text = "New Best!";
            PlayerPrefs.SetInt("NomalBestScore", Score.score);
        }
        else
        {
            bestScore.text = "Best : " + PlayerPrefs.GetInt("NomalBestScore");
        }

        jumpCountText.text = $"점프 한 횟수 : {circlejump.JumpCount}";

        if (killType == 0)
        {
            killLog.text = "아이스크림에 부딫혔습니다!";
        }
        else if (killType == 1)
        {
            killLog.text = "자전거에 부딫혔습니다!";
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
