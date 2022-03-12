using WonderfulMetaverseNetwork.Authentication;

namespace WonderfulMetaverseNetwork.Manager.Sub.Authentication
{
    public class AuthenticationManager
    {
        public Login login;
        public Register register;

        public AuthenticationManager(UIInputComponents uiInputComponents)
        {
            login = new Login(uiInputComponents.loginUsername, uiInputComponents.loginPassword);
            register = new Register(uiInputComponents.registerUsername, uiInputComponents.registerPassword, uiInputComponents.registerEmail);
        }
    }
}
