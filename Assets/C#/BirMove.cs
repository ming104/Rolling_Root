using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirMove : MonoBehaviour
{
    public float Speedb;

    void Update()
    {
        transform.position += new Vector3(-1, 0.23f, 0) * Speedb * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Score.score > PlayerPrefs.GetInt("bestscore"))
            {
                PlayerPrefs.SetInt("bestscore", Score.score);
                //Score.Bestscore = Score.score; 
            }
            if (collision.gameObject.name == "Circle")
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }
    }
}
