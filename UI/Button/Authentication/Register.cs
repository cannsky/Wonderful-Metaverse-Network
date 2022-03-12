using WonderfulMetaverseNetwork.Manager;

namespace WonderfulMetaverseNetwork.UI.Button.Authentication
{
    public class Register : Button
    {
        public void OnClick() => MetaverseManager.Instance.authenticationManager.register.UserRegister();
    }
}