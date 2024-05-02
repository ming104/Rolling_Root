using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
	private SpriteRenderer _spriteRenderer;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        //InvokeRepeating("RGBSee", 1, 0.1f);
        StartCoroutine("ColorChanged");
    }

    public IEnumerator ColorChanged()
    {
        while (true)
        {
            _spriteRenderer.color = Random.ColorHSV();
            yield return new WaitForSeconds(0.1f);
        }
    }
}
