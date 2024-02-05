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
    private bool canJumpLeft;
    private bool canJumpRight;
    public float raylength;
    public LayerMask groundlayer;

    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        if (inCaves)
        {
            ySpeed = 0;
            Jumppowa = 5f;
            raylength = 1f;

            offset = 0.375f;
        }

        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

   


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
            canJumpLeft = Physics2D.Raycast(transform.position + new Vector3(-offset, 0f, 0f), Vector2.down, raylength, groundlayer);
            canJumpRight = Physics2D.Raycast(transform.position + new Vector3(offset, 0f, 0f), Vector2.down, raylength, groundlayer);
            
            Debug.DrawRay(transform.position + new Vector3(-offset, 0f, 0f), Vector2.down, Color.red);
            Debug.DrawRay(transform.position + new Vector3(offset, 0f, 0f), Vector2.down, Color.green);
            if (Input.GetKeyDown("space") )
            {
                print("space was pressd");
                if (canJumpLeft || canJumpRight)
                {
                    Debug.Log("jumped");
                    m_Rigidbody.AddForce( new Vector2(0f,Jumppowa), ForceMode2D.Impulse);
                }
            }
        }
    }


}
