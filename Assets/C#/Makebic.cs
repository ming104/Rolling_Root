using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makebic : MonoBehaviour
{
    public GameObject bic;
    public AudioSource setbic;

    // Start is called before the first frame update
    void Start()
    {
        setbic = GetComponent<AudioSource>();
        InvokeRepeating("Madebic", 20, 1);
    }


    public void Madebic() {
        if (Random.Range(1, 101) > 95)
        {
            setbic.time = 0.12f;
            setbic.Play();
            GameObject newBicycle = Instantiate(bic);
            newBicycle.transform.position = new Vector3(-27f, 4.3f, 0);
            Destroy(newBicycle, 5.0f);
        }
}
}
