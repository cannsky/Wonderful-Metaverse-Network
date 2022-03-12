using UnityEngine;
using WonderfulMetaverseNetwork.Manager;
using WonderfulMetaverseNetwork.Manager.Sub.UserInterface.Worker;

namespace WonderfulMetaverseNetwork.UI.Button.Authentication
{
    public class SwitchPanel : MonoBehaviour
    {
        public void ChangeToLogin() => MetaverseManager.Instance.userInterfaceManager.menuUIWorker.ChangeUI(MenuUIWorker.UIType.Register, MenuUIWorker.UIType.Login);

        public void ChangeToRegister() => MetaverseManager.Instance.userInterfaceManager.menuUIWorker.ChangeUI(MenuUIWorker.UIType.Login, MenuUIWorker.UIType.Register);
    }
}