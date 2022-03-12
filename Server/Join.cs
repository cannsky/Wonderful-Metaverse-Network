using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

namespace WonderfulMetaverseNetwork.Server
{
    public class Join
    {
        public InputField userName;

        public void CreateRoom() => PhotonNetwork.CreateRoom("mainRoom");

        public void JoinRoom(){
            Debug.Log("test!");
            PhotonNetwork.JoinRoom("mainRoom");
            }

        public void OnJoinRoomFailed() => CreateRoom();

        public void OnJoinedRoom() => PhotonNetwork.LoadLevel("SampleScene");
    }

}