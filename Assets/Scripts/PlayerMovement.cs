using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float XDir;
    private float XVector;
    private float YDir;
    private float YVector;
    [SerializeField]
    public bool inCaves;
    public int xSpeed;
    public int ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        if (inCaves)
        {
            ySpeed = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        XDir = Input.GetAxis("Horizontal");
        XVector = XDir * xSpeed * Time.deltaTime;
        YDir = Input.GetAxis("Vertical");
        YVector = YDir * ySpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(XVector, 0f, 0f);
        transform.position = transform.position + new Vector3(0f, YVector, 0f);
    }
}
