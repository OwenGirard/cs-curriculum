using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverPlat : MonoBehaviour
{
    public Transform[] waypoints;
    private Lever script;

    private float speed;

    private int currentWaypointIndex = 0;
    public Vector3[] positions; 
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        transform.position = positions[0];
        script = GameObject.FindObjectOfType<Lever>();
        if (waypoints.Length > 0)
        {
            //positions = waypoints[currentWaypointIndex].position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (script.on)
        {
            //move
        }
    }
}
