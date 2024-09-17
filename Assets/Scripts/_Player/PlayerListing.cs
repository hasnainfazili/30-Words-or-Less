using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using TMPro;

public class PlayerListing : MonoBehaviourPunCallbacks
{
   public TextMeshProUGUI _text;
   private Player _player;

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        base.OnPlayerEnteredRoom(newPlayer);
    }

    public override void  OnPlayerLeftRoom(Player otherPlayer)
    {
        base.OnPlayerLeftRoom(otherPlayer);
    }
   public void SetPlayerInfo(Player player)
   {
        _player = player;
        _text.text = "Lora";
   }
}
