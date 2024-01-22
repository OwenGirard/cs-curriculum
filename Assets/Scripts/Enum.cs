using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enum : MonoBehaviour
{
  enum direction {North, South, East, West}

  private direction myDirection;
  
    void Start()
    {
        myDirection = direction.South;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myDirection = direction.West;
        }
        if 
    }

    
}
