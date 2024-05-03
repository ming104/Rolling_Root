using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bic : MonoBehaviour
{
    public float speed = 9;
    
    void Update()
    {
        transform.position += new Vector3(1, -0.241f, 0) * speed * Time.deltaTime;
    }
}
