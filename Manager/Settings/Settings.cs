using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace WonderfulMetaverseNetwork.Manager
{
    [System.Serializable]
    public class UIParentComponents
    {
        public GameObject Loading;
        public GameObject Login;
        public GameObject Register;
        public GameObject Lobby;
        public GameObject Join;
        public GameObject Buy;
        public GameObject Popup;
    }

    [System.Serializable]
    public class UIInputComponents
    {
        public TMP_InputField loginUsername;
        public TMP_InputField loginPassword;
        public TMP_InputField registerUsername;
        public TMP_InputField registerPassword;
        public TMP_InputField registerEmail;
    }

    [System.Serializable]
    public class UIComponents
    {
        public UIParentComponents uIParentComponents;
        public UIInputComponents uiInputComponents;
    }

    [System.Serializable]
    public class UserModel
    {
        public GameObject gameObject;
        public string name;
    }

    [System.Serializable]
    public class Settings
    {
        public string name = "New Metaverse World";
        public UIComponents uiComponents;
        public List<GameObject> userModels;
    }
} 