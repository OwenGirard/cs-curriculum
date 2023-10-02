using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class OverworldMovement : MonoBehaviour
{
    public int ySpeed;

    public int xSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 5;
        ySpeed = 5;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Input.GetAxis("Horizontal") * xSpeed) * Time.deltaTime,
            (Input.GetAxis("Vertical") * ySpeed) * Time.deltaTime, 0);
    }
}
