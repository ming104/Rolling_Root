using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class circlejump : MonoBehaviour
{
    public float jump;
    bool isJumping = false;
    public AudioSource soundJump;
    public float timeDiff;
    float timer = 0;
    public float t;
    private Animator anim;

    void Start()
    {
        Score.score = 0;
        t = 0;
        soundJump = GetComponent<AudioSource>();
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {

            if (isJumping == false)
            {
                soundJump.time = 0.12f;
                soundJump.Play();

                isJumping = true;

                GetComponent<Rigidbody2D>().AddForce(Vector3.up * jump);

            }

        }
        // ����___________________________________________________________
        t += 1;
        if (t > 50)
        {
            timeDiff -= 0.01f;
            t = 0;
        }
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            anim.speed += 0.00002f;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.name == "floor")
        {
            isJumping = false;
        }
        if(col.gameObject.CompareTag("Enemy"))
        {
            if (Score.score > PlayerPrefs.GetInt("bestscore"))
            {
                PlayerPrefs.SetInt("bestscore", Score.score);
            }
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
