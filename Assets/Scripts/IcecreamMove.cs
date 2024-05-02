using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcecreamMove : MonoBehaviour
{

    public static float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 9;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1, 0.24f, 0) * Speed * Time.deltaTime;
    }

}
