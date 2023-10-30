using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject Fireball;
    public Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        Target = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Target != null)
        {
            Instantiate(Fireball, transform.position, transform.rotation);
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Target = other.gameObject.transform;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Target = null;
        }
    }
}

