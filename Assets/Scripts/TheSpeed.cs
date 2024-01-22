using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSpeed : MonoBehaviour
{
    //private PlayerFireBall cheese;

    private float xspd;

    private float yspd;
    // Start is called before the first frame update
    void Start()
    {
        //cheese = GameObject.FindObjectOfType<PlayerFireBall>();
      //  xspd = cheese.firexvector;
      //  yspd = cheese.fireyvector;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector2(xspd, yspd));
        //Debug.Log(cheese); 
    }
}
