using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject Fireball;
    public Transform Target;
    public Transform shootpoint;
    public bool inrange;
    public float timerstart;
    public float towertimer;
    
    // Start is called before the first frame update
    void Start()
    {
        towertimer = 2f;
        timerstart = towertimer;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (towertimer > 0)
        {
            towertimer = towertimer - Time.deltaTime;
        }
        else
        {
            if (inrange)
            {
                fire();
            }
        }
    }

    //if (Target != null)
        //{
           // Instantiate(Fireball, transform.position, transform.rotation);
        //}
    


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inrange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inrange = false;
        }
    }



    void fire()
    {
        Instantiate(Fireball, shootpoint.position, shootpoint.rotation);
        towertimer = timerstart;
    }


    // void OnTriggerEnter2D(Collider2D other)
   // {
  //      if (other.gameObject.CompareTag("Player"))
    //    {
     //       Target = other.gameObject.transform;
    //    }
   // }
   // void OnTriggerExit2D(Collider2D other)
   //     if (other.gameObject.CompareTag("Player"))
     //   {
     //       Target = null;
     //   }
  //  }
}

