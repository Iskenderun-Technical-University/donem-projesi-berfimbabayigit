using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cat")
        {
            coinText.coinAmount += 1;
            Destroy(gameObject);
        }
    }
    void Update()
    {
        
    }
}
