using Photon.Pun;
using WonderfulMetaverseNetwork.Manager;
using WonderfulMetaverseNetwork.Manager.Sub.UserInterface.Worker;

namespace WonderfulMetaverseNetwork.Server
{
    public class Connect
    {

        public Connect() => PhotonNetwork.ConnectUsingSettings();

        public void OnConnectedToMaster() => PhotonNetwork.JoinLobby();

        public void OnJoinedLobby() => MetaverseManager.Instance.userInterfaceManager.menuUIWorker.ChangeUI(MenuUIWorker.UIType.Loading, MenuUIWorker.UIType.Login);

    }
}