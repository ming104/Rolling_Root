using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bic : MonoBehaviour
{
    public float Sp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, -0.25f, 0) * Sp * Time.deltaTime;
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
