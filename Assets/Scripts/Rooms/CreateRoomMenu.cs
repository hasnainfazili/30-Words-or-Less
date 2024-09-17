using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using TMPro;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
    public TextMeshProUGUI roomName;

    public void OnClick_CreateRoom()
    {
        if(!PhotonNetwork.IsConnected)
            return;
            
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 6;
        PhotonNetwork.JoinOrCreateRoom(roomName.text, options, TypedLobby.Default);
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("Create Room Success");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Create Room Failed");
    }
}
