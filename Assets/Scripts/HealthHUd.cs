using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HealthHUd : MonoBehaviour
{
    public Damage purse;

    public TextMeshProUGUI HealthText; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = "Health"; 

    }
}
