using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcecreamMove : MonoBehaviour
{

    public static float Speed;
    public float C;
    public GameObject SIM;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 9;
        C = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1, 0.24f, 0) * Speed * Time.deltaTime;
        C += 0.05f;
        if(C > 50)
        {
            Speed += 1f;
            C = 0;
        }
    }

}
