using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icecreamge : MonoBehaviour
{
    public GameObject icecream;

    public static float timeDiff;
    float timer = 0;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        timeDiff = 5;
    }

    // Update is called once per frame
    void Update()
    {
        t += 1;
        if (t > 50)
        {
            timeDiff -= 0.01f;
            t = 0;
        }
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newicecream = Instantiate(icecream);
            newicecream.transform.position = new Vector3 (-0.28f, -0.5f, 0) * Time.deltaTime;
            timer = 0;
            Destroy(newicecream, 10.0f);
        }
    }
}
