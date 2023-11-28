using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float moveSpeed;
    public float waittodestroy = 1f;

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
        Invoke("DestroyFireball",waittodestroy);
    }

    //OnTriggerEnter2D()
  

    // Update is called once per frame
    void Update()
    {
       // transform.position = new Vector3(
       //     transform.position.x + (moveSpeed * Time.deltaTime),
        //    transform.position.y,
       //     transform.position.z
       // );
       
       transform.Translate(new Vector2(moveSpeed*Time.deltaTime, 0f));
    }

    void DestroyFireball()
    {
        Destroy(gameObject);
    }
    
    
}
