using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawner : MonoBehaviour
{
    public GameObject playerprefab;
    public float minX;
    public float minZ;
    public float maxX;
    public float maxZ;
    void Start()
    {
        Vector3 ranposition = new Vector3(Random.Range(minX, maxX), 3, Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(playerprefab.name, ranposition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
