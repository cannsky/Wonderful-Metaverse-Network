using UnityEngine;
using WonderfulMetaverseNetwork.UI.Popup;

namespace WonderfulMetaverseNetwork.Manager.Sub.UserInterface.Worker
{
    public class MenuUIWorker
    {
        public enum UIType
        {
            Loading,
            Login,
            Register,
            Lobby,
            Join,
            Buy,
            Popup
        }

        private GameObject GetUIGameObject(UIType index)
        {
            return index switch {
                UIType.Loading => MetaverseManager.Instance.userInterfaceManager.settings.uiComponents.uIParentComponents.Loading,
                UIType.Login => MetaverseManager.Instance.userInterfaceManager.settings.uiComponents.uIParentComponents.Login,
                UIType.Register => MetaverseManager.Instance.userInterfaceManager.settings.uiComponents.uIParentComponents.Register,
                UIType.Lobby => MetaverseManager.Instance.userInterfaceManager.settings.uiComponents.uIParentComponents.Lobby,
                UIType.Popup => MetaverseManager.Instance.userInterfaceManager.settings.uiComponents.uIParentComponents.Popup,
                _ => MetaverseManager.Instance.userInterfaceManager.settings.uiComponents.uIParentComponents.Loading
            };
        }

        public void ChangeUI(UIType oldUI, UIType newUI)
        {
            GetUIGameObject(oldUI).SetActive(false);
            GetUIGameObject(newUI).SetActive(true);
        }

        public void OpenPopupUI() => GetUIGameObject(UIType.Popup).SetActive(true);

        public void ClosePopupUI() => GetUIGameObject(UIType.Popup).SetActive(false);
    }
}
