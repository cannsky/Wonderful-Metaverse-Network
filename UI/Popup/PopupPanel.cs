using TMPro;
using UnityEngine;
using WonderfulMetaverseNetwork.Manager;

namespace WonderfulMetaverseNetwork.UI.Popup
{
    public class PopupPanel : MonoBehaviour
    {
        public static PopupPanel Instance;

        public static string title;
        public static string message;

        public TextMeshProUGUI titleText;
        public TextMeshProUGUI messageText;

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            else Destroy(this);
        }

        public void OnEnable() => UpdateTMProText();

        public static void UpdatePopupText(string title, string message)
        {
            PopupPanel.title = title;
            PopupPanel.message = message;
            if (Instance && Instance.gameObject.activeSelf) UpdateTMProText();
        }

        public static void UpdateTMProText()
        {
            Instance.titleText.text = title;
            Instance.messageText.text = message;
        }

        public void ClosePopup() => MetaverseManager.Instance.userInterfaceManager.menuUIWorker.ClosePopupUI();
    }
}
