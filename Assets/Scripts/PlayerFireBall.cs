using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireBall : MonoBehaviour
{
    public GameObject playerFireBall;

    public float firex;
    public float firey;
    public float firexvector;
    public float fireyvector;
    public float fireballspd;
    // Start is called before the first frame update
    void Start()
    {
        fireballspd = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        firex = Input.GetAxis("Horizontal");
        firey = Input.GetAxis("Vertical");
        fireyvector = firey * fireballspd * Time.deltaTime;
        firexvector = firex * fireballspd * Time.deltaTime;
        if(Input.GetKeyDown("space"))
        {
            Instantiate(playerFireBall, transform.position, transform.rotation);
        }

     
    }
}
