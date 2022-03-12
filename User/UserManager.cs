using UnityEngine;
using Photon.Pun;

namespace WonderfulMetaverseNetwork.User
{
    public class UserManager : MonoBehaviour
    {
        public UserSettings userSettings;
        public UserInput userInput;
        public PhotonView view;

        private void Awake() => InitializeUser();

        private void Start()
        {
            userInput = new UserInput(transform, GetComponent<CharacterController>(), userSettings.mainCamera);
            view = GetComponent<PhotonView>();
            if (!view.IsMine) DisableUserManagerComponents();
        }

        private void Update()
        {
            if (!view.IsMine) return;
            int movement = userInput.CheckInput();
            if (movement == 1) userSettings.animator.SetBool("Walk", true);
            else userSettings.animator.SetBool("Walk", false);
        }

        public void InitializeUser() => userSettings.animator.runtimeAnimatorController = userSettings.animatorController;

        public void DisableUserManagerComponents()
        {
            transform.GetChild(1).gameObject.SetActive(false);
            //this.gameObject.SetActive(false);
        }
    }
}