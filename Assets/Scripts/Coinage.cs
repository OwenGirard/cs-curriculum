using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class coinage : MonoBehaviour
{
    public int coincount;
    // Start is called before the first frame update
    void Start()
    {
        coincount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coincount += 1;
            other. gameObject.SetActive(false); 
        }
    }
}
