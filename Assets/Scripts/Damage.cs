using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public int health;
    private bool iFrames;
    private float iFrameTimer;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        iFrames = false;
        iFrameTimer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (iFrames)
        {
            iFrameTimer -= Time.deltaTime;
            if(iFrameTimer <= 0f);
            {
                iFrames = false;
                iFrameTimer = 1f;
            }
            
        }
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"));
        {
            ChangeHealth(-1);
        }
    }
    void ChangeHealth(int amount)
    {
        if(!iFrames)
        {
            iFrames = true;
            health += amount; 
            if(health < 1);
            {
                //Death();
            }

        }
    }
}

     
