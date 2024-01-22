using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

// public class PlayerFireBall : MonoBehaviour
// {
//     public GameObject playerFireBall;
//
//     public static PlayerFireBall cheese;
//     
//     public float firex;
//     public float firey;
//     public float firexvector;
//     public float fireyvector;
//     public float fireballspd;
//     // Start is called before the first frame update
//     void Start()
//     {
//         fireballspd = 10f;
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         
//         {
//             if (!(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)))
//             {
//                 firey = 0f;
//             }
//             firex = Input.GetAxis("Horizontal");
//         }
//
//         if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
//         {
//             if (!(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)))
//             {
//                 firex = 0f;
//             }
//             firey = Input.GetAxis("Vertical");
//         }
//
//         if (firex != 0)
//         {
//             firexvector = firex * fireballspd * Time.deltaTime;
//         }
//
//         if (firey != 0)
//         {
//             fireyvector = firey * fireballspd * Time.deltaTime;
//         }
//         
//         
//         if(Input.GetKeyDown("space"))
//         {
//             Instantiate(playerFireBall, transform.position, transform.rotation);
//             Debug.Log("works");
//         }
//
//         //Debug.Log(firex); 
//      

