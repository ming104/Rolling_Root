using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RGBver1 : MonoBehaviour
{
	SpriteRenderer render;
    void Start()
    {
		render = GetComponent<SpriteRenderer>();
        InvokeRepeating("RGBSee", 1, 0.1f);
    }

    public void RGBSee()
    {
        render.color = Random.ColorHSV();
    }
}
