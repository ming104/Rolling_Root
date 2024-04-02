using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class icecream : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.name == "Circle")
        {
            Score.score += 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            if (Score.score > PlayerPrefs.GetInt("bestscore"))
            {
                PlayerPrefs.SetInt("bestscore", Score.score);
                //Score.Bestscore = Score.score; 
            }
            if (col.gameObject.name == "Circle")
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }
    }
}