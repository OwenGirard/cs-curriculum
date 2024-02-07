using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour

{
    public float Uplimit;
    public float movespeed;
    public float direction;
    public float downlimit;
    // Start is called before the first frame update
    void Start()
    {
        direction = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < downlimit)
        {
            direction = 1f;
        }
        if (transform.position.y > Uplimit)
        {
            direction = -1f;
        }
        
        transform.position = transform.position + new Vector3(0f, movespeed * direction * Time.deltaTime, 0f);
    }
}
