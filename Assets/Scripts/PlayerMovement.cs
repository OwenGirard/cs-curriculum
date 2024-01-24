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
        if (Input.GetKeyDown("space") && canjump)
        {
            Debug.Log("jumped");
            m_Rigidbody.AddForce(transform.up * Jumppowa); 
        }
        
        // Bit shift the index of the layer (8) to get a bit mask
        //int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        //layerMask = ~layerMask;

        //RaycastHit hit;
        
        
        // Does the ray intersect any objects excluding the player layer
       //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), raylength))
       // {
      //      
      //      Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down), Color.yellow);
       //     //Debug.Log("Did Hit");
        //    canjump = true;
       // }
        //else
        //{
       //     Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 10, Color.white);
            //Debug.Log("Did not Hit");
        //    canjump = false;

        }
        
        //Debug.Log(hit);
        

    }

   // private void FixedUpdate()
   // {
     //   RaycastHit2D hit = Physics2D.Raycast(Transform.position, -Vector2.up);
      //  if (hit.collider != null)
    //    {
     //       // Calculate the distance from the surface and the "error" relative
      //      // to the floating height.
      //      float distance = Mathf.Abs(hit.point.y - Transform.position.y);
       //     float heightError = Jumppowa - distance;

       //     // The force is proportional to the height error, but we remove a part of it
            // according to the object's speed.
       //     float force = liftForce * heightError - m_Rigidbody .velocity.y * damping;

            // Apply the force to the rigidbody.
        //    m_Rigidbody.AddForce(Vector3.up * force);
       // }
   // }
//}
    
