using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += new Vector3(-1,0,0) * Time.deltaTime;
            rb.velocity = new Vector3(-1, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += new Vector3(2, 0, 0) * Time.deltaTime;
            }
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, -1, 0);
        }

        
    }

}
