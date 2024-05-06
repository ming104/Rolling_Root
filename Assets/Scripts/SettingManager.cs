using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    public GameObject gameStartPanel;
    public Text nomalScoreText;
    public Text itemScoreText;
    
    public GameObject settingPanel;
    
    public Slider bgmSlider;
    public Slider sfxSlider;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        GameStartPanelOff();
        SettingPanelOff();
        if (!PlayerPrefs.HasKey("bgmSoundVolume") && !PlayerPrefs.HasKey("sfxSoundVolume"))
        {
            PlayerPrefs.SetFloat("bgmSoundVolume", 1f);
            PlayerPrefs.SetFloat("sfxSoundVolume", 1f);
        }
        if (!PlayerPrefs.HasKey("NomalBestScore") && !PlayerPrefs.HasKey("ItemBestScore"))
        {
            PlayerPrefs.SetInt("NomalBestScore", 0);
            PlayerPrefs.SetInt("ItemBestScore", 0);
        }

        nomalScoreText.text = $"-최고 점수 : {PlayerPrefs.GetInt("NomalBestScore")}점";
        itemScoreText.text = $"-최고 점수 : {PlayerPrefs.GetInt("ItemBestScore")}점";
        bgmSlider.value = PlayerPrefs.GetFloat("bgmSoundVolume");
        sfxSlider.value = PlayerPrefs.GetFloat("sfxSoundVolume");
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            //SceneManager.LoadScene("Play");
            GameStartPanelOn();
        }

    }

    public void SettingEnd()
    {
        PlayerPrefs.SetFloat("bgmSoundVolume", bgmSlider.value);
        PlayerPrefs.SetFloat("sfxSoundVolume", sfxSlider.value);
        SettingPanelOff();
    }

    public void SettingPanelOn()
    {
        settingPanel.SetActive(true);
    }
    
    public void SettingPanelOff()
    {
        settingPanel.SetActive(false);
    }

    public void GameStartPanelOn()
    {
        gameStartPanel.SetActive(true);
    }
    public void GameStartPanelOff()
    {
        gameStartPanel.SetActive(false);
    }

    public void NomalGameStart()
    {
        SceneManager.LoadScene("Nomalplay");
        //Debug.Log("NomalGameStart");
    }
    
    public void ItemGameStart()
    {
        SceneManager.LoadScene("Itemplay");
        //Debug.Log("ItemGameStart");
    }
}
