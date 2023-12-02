using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ServerController : MonoBehaviourPunCallbacks
{
    public GameObject startbutton;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        startbutton.SetActive(false);
        print("Connecting...");
    }

    public override void OnConnectedToMaster()
    {
        startbutton.SetActive(true);
        PhotonNetwork.AutomaticallySyncScene = true;
        print("Connected to server in " + PhotonNetwork.CloudRegion + ". Bomba.");
    }
}
