using TMPro;
using PlayFab;
using PlayFab.ClientModels;
using WonderfulMetaverseNetwork.Manager;
using WonderfulMetaverseNetwork.UI.Popup;
using WonderfulMetaverseNetwork.Manager.Sub.UserInterface.Worker;

namespace WonderfulMetaverseNetwork.Authentication
{
    public class Register
    {
        public TMP_InputField username;
        public TMP_InputField password;
        public TMP_InputField email;
        private RegisterPlayFabUserRequest registerPlayFabUserRequest;

        public Register(TMP_InputField username, TMP_InputField password, TMP_InputField email)
        {
            this.username = username;
            this.password = password;
            this.email = email;
        }

        public void UserRegister()
        {
            registerPlayFabUserRequest = new RegisterPlayFabUserRequest();
            registerPlayFabUserRequest.Username = username.text;
            registerPlayFabUserRequest.Password = password.text;
            registerPlayFabUserRequest.Email = email.text;
            PopupPanel.UpdatePopupText("REGISTERING", "PLEASE WAIT, REGISTERING TO THE WONDERFUL METAVERSE NETWORK.");
            MetaverseManager.Instance.userInterfaceManager.menuUIWorker.OpenPopupUI();
            PlayFabClientAPI.RegisterPlayFabUser(registerPlayFabUserRequest,
                result => {
                    PopupPanel.UpdatePopupText("REGISTERED", "YOU ARE SUCCESSFULLY REGISTERED. YOU CAN LOGIN NOW.");
                    MetaverseManager.Instance.userInterfaceManager.menuUIWorker.ChangeUI(MenuUIWorker.UIType.Register, MenuUIWorker.UIType.Login);
                },
                error => {
                    PopupPanel.UpdatePopupText("REGISTER ERROR!", error.ErrorMessage.ToUpper());
                });
        }
    }
}