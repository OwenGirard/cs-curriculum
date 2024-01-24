using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float XDir;
    private float XVector;
    private float YDir;
    private float YVector;
    [SerializeField] public bool inCaves;
    public int xSpeed;
    public int ySpeed;
    public float Jumppowa;
    private Rigidbody m_Rigidbody;
    private bool canjump;
    // Start is called before the first frame update
    void Start()
    {
        if (inCaves)
        {
            ySpeed = 0;
            Jumppowa = 1f;
        }

        m_Rigidbody = GetComponent<Rigidbody>();
    }
    
    

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, -Vector2.up, Color.green);
        XDir = Input.GetAxis("Horizontal");
        XVector = XDir * xSpeed * Time.deltaTime;
        YDir = Input.GetAxis("Vertical");
        YVector = YDir * ySpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(XVector, 0f, 0f);
        transform.position = transform.position + new Vector3(0f, YVector, 0f);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_Rigidbody.AddForce(transform.up * Jumppowa); 
        }


    }

    private void FixedUpdate()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity,
                layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance,
                Color.yellow);
            Debug.Log("Did Hit");
            canjump = true;
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
            canjump = false;

        }
    }
}
    
