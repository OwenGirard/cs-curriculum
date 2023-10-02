using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float XDir;
    float XVector;
    float WalkingSpeed;
    // Start is called before the first frame update
    void Start()
    {
        WalkingSpeed = 5f; 
    }

    // Update is called once per frame
    void Update()
    {
        XDir = Input.GetAxis("Horizontal");
        XVector = XDir * WalkingSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(XVector, 0f, 0f);
    }
}
