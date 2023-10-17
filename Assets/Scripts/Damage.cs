using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public HUD hud;
    private bool iFrames;
    private float iFrameTimer;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        
        iFrames = false;
        iFrameTimer = 1f;
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
        if (other.gameObject.CompareTag("Spikes"))
        {
            ChangeHealth(-1);
        }
    }

    void Death()
    {
        SceneManager.LoadScene("Start");
        
        iFrames = false;
        iFrameTimer = 1f;
    }
    void ChangeHealth(int amount)
    {
        if(!iFrames)
        {
            iFrames = true;
            hud.health += amount;
            if (hud.health < 1) 
            {
                hud.health = 3;
                Death();
            }

        }
    }
}

     
