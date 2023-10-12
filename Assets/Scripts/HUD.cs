using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public static HUD hud;
    public int coins;
    public int health;
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI cointext;
    
    // Start is called before the first frame update

    private void Awake()
    {
        if (hud !=null && hud!=this)
        {
            Destroy(gameObject);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    


    void Start()
    {
        coins = 0;
        health = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        cointext.text = "Coins " + coins;
        HealthText.text = "Health " + health; 
    }
}
