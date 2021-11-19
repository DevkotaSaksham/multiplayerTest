using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class animationcontroller : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
       
        animator = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("iswalking", true);
        }
        if (!Input.GetKey("w"))
        {
            animator.SetBool("iswalking", false);
        }
        //for right walk
        if (Input.GetKey("d"))
        {
            animator.SetBool("isrightwalking", true);
        }
        if (!Input.GetKey("d"))
        {
            animator.SetBool("isrightwalking", false);
        }
        //for left walking
        if (Input.GetKey("a"))
        {
            animator.SetBool("isleftwalking", true);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("isleftwalking", false);
        }
        //for back walking
        if (Input.GetKey("s"))
        {
            animator.SetBool("isbackwalking", true);
        }
        if (!Input.GetKey("s"))
        {
            animator.SetBool("isbackwalking", false);
        }

        //forjump
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isjumping", true);
        }
        if (!Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isjumping", false);
        }
        //forkicking
        if (Input.GetKey("e"))
        {
            animator.SetBool("iskicking", true);
        }
        if (!Input.GetKey("e"))
        {
            animator.SetBool("iskicking", false);
        }
    }
}
