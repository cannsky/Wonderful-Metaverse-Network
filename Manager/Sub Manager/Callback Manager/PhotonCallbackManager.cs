using Photon.Pun;

namespace WonderfulMetaverseNetwork.Manager.Sub.Callback
{
    public class PhotonCallbackManager : MonoBehaviourPunCallbacks
    {
        public static PhotonCallbackManager Instance;

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            else Destroy(this);
        }

        public override void OnJoinedRoom() => MetaverseManager.Instance.serverManager.join.OnJoinedRoom();

        public override void OnJoinRoomFailed(short returnCode, string message) => MetaverseManager.Instance.serverManager.join.OnJoinRoomFailed();

        public override void OnConnectedToMaster() => MetaverseManager.Instance.serverManager.connect.OnConnectedToMaster();

        public override void OnJoinedLobby() => MetaverseManager.Instance.serverManager.connect.OnJoinedLobby();
    }
}