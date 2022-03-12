using UnityEngine;
using WonderfulMetaverseNetwork.Manager.Sub.Data;
using WonderfulMetaverseNetwork.Manager.Sub.Server;
using WonderfulMetaverseNetwork.Manager.Sub.UserInterface;
using WonderfulMetaverseNetwork.Manager.Sub.Authentication;

namespace WonderfulMetaverseNetwork.Manager
{
    public class MetaverseManager : MonoBehaviour
    {
        public static MetaverseManager Instance;
        public Settings settings;

        public DataManager dataManager;
        public ServerManager serverManager;
        public UserInterfaceManager userInterfaceManager;
        public AuthenticationManager authenticationManager;

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            else Destroy(this);
            dataManager = new DataManager();
            serverManager = new ServerManager();
            userInterfaceManager = new UserInterfaceManager(settings);
            authenticationManager = new AuthenticationManager(settings.uiComponents.uiInputComponents);
        }
    }
}