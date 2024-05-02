using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //pc
        if (Input.anyKeyDown) SceneManager.LoadScene("Play");
        // ����!
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
		if (Input.GetMouseButtonDown(0)) SceneManager.LoadScene("Play");

    }
}
