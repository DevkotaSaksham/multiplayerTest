using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    
    Rigidbody rb;

    public float speed = 10f;
    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
       
        
    }
    

    // Update is called once per frame
    void Update()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // transform.Translate(dir * speed * Time.deltaTime);
        rb.velocity = dir * speed;
        //forwalking
        
    }
}
