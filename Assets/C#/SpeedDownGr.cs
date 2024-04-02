using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDownGr : MonoBehaviour
{
    public GameObject SItem;
    public AudioSource sounditem;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MadeSItem", 10, 1);
    }

    public void MadeSItem()
    {
        if (Random.Range(1, 101) > 99)
        {
            GameObject newSItem = Instantiate(SItem);
            newSItem.transform.position = new Vector3(4, -3f, 0);
            Destroy(newSItem, 5.0f);
        }
    }
}

