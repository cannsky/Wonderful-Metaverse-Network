using TMPro;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using WonderfulMetaverseNetwork.Manager;
using WonderfulMetaverseNetwork.UI.Popup;
using WonderfulMetaverseNetwork.GameData.User;

namespace WonderfulMetaverseNetwork.Authentication
{
    public class Login
    {
        public TMP_InputField username;
        public TMP_InputField password;
        private LoginWithPlayFabRequest loginWithPlayFabRequest;
        public Dictionary<string, int> virtualCurrency = new Dictionary<string, int>();

        public Login(TMP_InputField username, TMP_InputField password)
        {
            this.username = username;
            this.password = password;
        }

        public void UserLogin()
        {
            loginWithPlayFabRequest = new LoginWithPlayFabRequest();
            loginWithPlayFabRequest.Username = username.text;
            loginWithPlayFabRequest.Password = password.text;
            PopupPanel.UpdatePopupText("LOGINNING", "PLEASE WAIT, LOGINNING TO THE WONDERFUL METAVERSE NETWORK.");
            MetaverseManager.Instance.userInterfaceManager.menuUIWorker.OpenPopupUI();
            PlayFabClientAPI.LoginWithPlayFab(loginWithPlayFabRequest,
                result =>
                {
                    PlayFabClientAPI.GetUserInventory(
                        new GetUserInventoryRequest { },
                        result =>
                        {
                            virtualCurrency = result.VirtualCurrency;
                            MetaverseManager.Instance.dataManager.data.userData.UpdateUserData(UserData.DataType.UserCurrencyData, "Gold", virtualCurrency["GL"].ToString());
                            MetaverseManager.Instance.dataManager.data.userData.UpdateUserData(UserData.DataType.UserCurrencyData, "Diamond", virtualCurrency["DA"].ToString());
                            MetaverseManager.Instance.serverManager.join.JoinRoom();
                        },
                        error =>
                        {
                            //Nothing!!
                        }
                    );
                },
                error => {
                    PopupPanel.UpdatePopupText("LOGIN ERROR!", error.ErrorMessage.ToUpper());
                }, null);
        }
    }
}