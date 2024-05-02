using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("game out");
    }
    
}
