using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IcecreamUP : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (Score.score > Score.Bestscore)
        {
            Score.Bestscore = Score.score;
        }
        if (col.gameObject.name == "Circle")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
