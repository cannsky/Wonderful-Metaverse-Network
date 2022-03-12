using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WonderfulMetaverseNetwork.User
{
    [System.Serializable]
    public class AnimatiorControllerParameter
    {
        public enum AnimationType { Walk, Idle }
        public AnimationType animationType;
        public string parameterString;
    }

    [System.Serializable]
    public class UserModel
    {
        public GameObject gameObject;
        public string name;
    }

    [System.Serializable]
    public class UserSettings
    {
        public Animator animator;
        public RuntimeAnimatorController animatorController;
        public List<AnimatiorControllerParameter> animatorControllerParameters;
        public Transform mainCamera;
        public List<UserModel> userModels;
    }
}