using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.SpriteAssetUtilities;
using UnityEngine;

public class leverPlat : MonoBehaviour
{
    
    private Lever script;

    private float speed;
    private bool forward = true;
    private int currentWaypointIndex = 0;
    public Vector2[] positions; 
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        transform.position = positions[currentWaypointIndex];
        script = GameObject.FindObjectOfType<Lever>();
       
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            other.gameObject.transform.SetParent(null);
        }
    }

    void Update()
    {
        if (script.on)
        {
            transform.position = Vector2.MoveTowards(transform.position, positions[currentWaypointIndex],
                speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, positions[currentWaypointIndex]) < 0.5f)
            {
                if (forward)
                {
                    if (currentWaypointIndex != positions.Length - 1)
                    {
                        currentWaypointIndex++;
                    }
                    else
                    {
                        forward = false;
                    }
                }
                else
                {
                    if (currentWaypointIndex != 0)
                    {
                        currentWaypointIndex--;
                    }
                    else
                    {
                        forward = true;
                    }
                }
            }
        }
    }
}
