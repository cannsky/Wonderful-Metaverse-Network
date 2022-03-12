using WonderfulMetaverseNetwork.Manager;

namespace WonderfulMetaverseNetwork.UI.Button.Authentication
{
    public class Login : Button
    {
        public void OnClick() => MetaverseManager.Instance.authenticationManager.login.UserLogin();
    }
}