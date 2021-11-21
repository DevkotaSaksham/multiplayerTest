using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class createjoinroom : MonoBehaviourPunCallbacks
{

    public InputField createinput;
    public InputField joininput;

    void Start()
    {
        
    }

   public void createroomforme() {
        PhotonNetwork.CreateRoom(createinput.text);
    }

    public void joinroomforme()
    {
        PhotonNetwork.JoinRoom(joininput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("gamescene");
    }

    void Update()
    {
        
    }
}
