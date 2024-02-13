using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class platformtwo : MonoBehaviour
{
    public bool Switch;
    public Vector2 positionOne;
    //public   
    private Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        Switch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Switch)
        {
            target = positionOne;
            transform.position = Vector2.MoveTowards(transform.position, target, 100f);
        }   
       // if (Distance<>)
    }
}
