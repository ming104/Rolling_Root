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
    private Rigidbody2D _rigid;
    
    public static int JumpCount;

    void Start()
    {
        Score.score = 0;
        t = 0;
        JumpCount = 0;
        //soundJump = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        _rigid = GetComponent<Rigidbody2D>();

        soundJump.volume = PlayerPrefs.GetFloat("sfxSoundVolume");
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (isJumping == false && PlayManager.Instance.RootDie == false)
            {
                soundJump.time = 0.12f;
                soundJump.Play();
                JumpCount++;

                isJumping = true;

                _rigid.AddForce(Vector3.up * jump);

            }
        }
         // ����___________________________________________________________
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
        // if (col.gameObject.CompareTag("Enemy"))
        // {
        //     if (Score.score > PlayerPrefs.GetInt("bestscore"))
        //     {
        //         PlayerPrefs.SetInt("bestscore", Score.score);
        //     }
        //     SceneManager.LoadScene("GameOverScene");
        // }
    }
}
