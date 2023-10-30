using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class trakingsystem : MonoBehaviour
{
    public Transform target; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (target.position = transform.position);
        float angle = Mathf.Atan2(direction.y, direction.x);
        Vector2 newPosition = (Vector2)transform.position + direction.normalized * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, angle * Mathf.Rad2Deg);
    }
}
