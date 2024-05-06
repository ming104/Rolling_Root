using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icecream : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Circle"))
        {
            PlayManager.Instance.killType = 0;
            PlayManager.Instance.RootdiePanelOn();
            //SceneManager.LoadScene("GameOverScene");
        }
    }
}
