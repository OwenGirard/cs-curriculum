using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireBall : MonoBehaviour
{
    public GameObject playerFireBall;

    public static PlayerFireBall cheese;
    
    public float firex;
    public float firey;
    public float firexvector;
    public float fireyvector;
    public float fireballspd;
    // Start is called before the first frame update
    void Start()
    {
        fireballspd = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        firex = Input.GetAxis("Horizontal");
        firey = Input.GetAxis("Vertical");

        if (firex != 0)
        {
            firexvector = firex * fireballspd * Time.deltaTime;
        }

        if (firey != 0)
        {
            fireyvector = firey * fireballspd * Time.deltaTime;
        }
        
        
        if(Input.GetKeyDown("space"))
        {
            Instantiate(playerFireBall, transform.position, transform.rotation);
        }

        //Debug.Log(firex);
     
    }
}
