using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeEnemy : MonoBehaviour
{
    public GameObject bicycle;
    public AudioSource setBicycle;
    
    public GameObject iceCream;

    public Transform iceCreamSpawnPoint;
    public Transform bicycleSpawnPoint;

    private float _iceCreamSummonTime = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        setBicycle = GetComponent<AudioSource>();
        StartCoroutine("MakeIceCream");
        StartCoroutine("MakeBicycle");
        _iceCreamSummonTime = 5f;
    }
    
    public IEnumerator MakeIceCream()
    {
        while (true)
        {
            GameObject newIceCream = Instantiate(iceCream);
            newIceCream.transform.position = iceCreamSpawnPoint.position;
            Destroy(newIceCream, 10.0f);

            yield return new WaitForSeconds(_iceCreamSummonTime);
            _iceCreamSummonTime -= 0.01f;
        }
    }
    
    public IEnumerator MakeBicycle()
    {
        yield return new WaitForSeconds(20f);
        while (true)
        {
            if (Random.Range(1, 101) > 95)
            {
                setBicycle.time = 0.12f;
                setBicycle.Play();
                GameObject newBicycle = Instantiate(bicycle);
                newBicycle.transform.position = bicycleSpawnPoint.position;
                Destroy(newBicycle, 5.0f);
            }
            yield return new WaitForSeconds(1f);
        }
    }


}
