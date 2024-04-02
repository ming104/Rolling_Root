using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panelitem : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            ClickKeySetting();
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            ClickKeySettingOut();
        }
    }

    public void ClickKeySetting()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClickKeySettingOut()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
