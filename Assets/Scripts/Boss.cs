using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Lever script;

    private float speed;
    private bool forward = true;
    private int Index = 0;
    public Vector2[] waypoints; 
    // Start is called before the first frame update
    void Start()
    {
        speed = 50f;
        transform.position = waypoints[Index];
    }

    // Update is called once per frame
    void Update()
    {
        
        
            
            
                transform.position = Vector2.MoveTowards(transform.position, waypoints[Index],
                    speed * Time.deltaTime);
                if (Vector2.Distance(transform.position, waypoints[Index]) < 0.5f)
                {
                    if (forward)
                    {
                        if (Index != waypoints.Length - 1)
                        {
                            Index++;
                        }
                        else
                        {
                            forward = false;
                        }
                    }
                    else
                    {
                        if (Index != 0)
                        {
                            Index--;
                        }
                        else
                        {
                            forward = true;
                        }
                    }
                }
            
        
    }
}
