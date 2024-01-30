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
    private Rigidbody2D m_Rigidbody;
    private bool canjump;
   // public Transform startpoint;
    public float raylength;

    // Start is called before the first frame update
    void Start()
    {
        if (inCaves)
        {
            ySpeed = 0;
            Jumppowa = 200f;
        }

        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    //public LayerMask groundlayer;


    // Update is called once per frame
    void Update()
    {
        XDir = Input.GetAxis("Horizontal");
        XVector = XDir * xSpeed * Time.deltaTime;
        YDir = Input.GetAxis("Vertical");
        YVector = YDir * ySpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(XVector, 0f, 0f);
        transform.position = transform.position + new Vector3(0f, YVector, 0f);
        
        if (inCaves)
        {
            canjump = Physics2D.Raycast(transform.position, Vector2.down, 1f);
            Debug.DrawRay(transform.position, Vector2.down, Color.green);
            if (Input.GetKeyDown("space") )
            {
                print("space was pressd");
                if (canjump)
                {
                    Debug.Log("jumped");
                    m_Rigidbody.AddForce(transform.up * Jumppowa);
                }
            }
        }
    }


}
