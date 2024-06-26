using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bicycle : MonoBehaviour
{
    public float speed = 9;
    
    void Update()
    {
        transform.position += new Vector3(1, -0.241f, 0) * speed * Time.deltaTime;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Circle"))
        {
            PlayManager.Instance.killType = 1;
            PlayManager.Instance.RootdiePanelOn();
            //SceneManager.LoadScene("GameOverScene");
        }
    }
}
