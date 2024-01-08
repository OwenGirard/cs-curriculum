using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireBall : MonoBehaviour
{
    public GameObject fire;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown("space"))
        {
            //Instantiate(fire.GetComponent(), transform.position, transform.rotation);
        }
        transform.position = new Vector3(
            transform.position.x + (moveSpeed * Time.deltaTime),
            transform.position.y,
            transform.position.z
        );
    }
}
