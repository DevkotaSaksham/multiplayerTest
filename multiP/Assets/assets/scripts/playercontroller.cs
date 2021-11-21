using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class playercontroller : MonoBehaviour
{
    AudioListener audiolistenerr;
    
    Rigidbody rb;
    PhotonView pv;
    public float speed = 10f;
    void Start()
    {
        audiolistenerr = GetComponentInChildren<AudioListener>();
         rb = GetComponent<Rigidbody>();
        pv = GetComponent<PhotonView>();
       

    }
   

    // Update is called once per frame
    void Update()
    {
        if (!pv.IsMine) { 
            Destroy(audiolistenerr);
            Destroy(GetComponent<playercontroller>());
        }

        if (pv.IsMine) {
            var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            rb.velocity = dir * speed;
        }
        

       
       
    }
}
