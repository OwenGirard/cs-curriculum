using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private GameObject Player;
    public float moveSpeed = 5f;
    public GameObject Fireball;

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        //Target
    }

    //OnTriggerEnter2D()
  

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x + (moveSpeed * Time.deltaTime),
            transform.position.y,
            transform.position.z
        );
    }
}
