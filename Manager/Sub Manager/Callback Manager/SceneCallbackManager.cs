using System;
using UnityEngine;

namespace WonderfulMetaverseNetwork.Manager.Sub.Callback
{
    public class SceneCallbackManager : MonoBehaviour
    {
        public static Action onLoaderCallback;

        public static SceneCallbackManager Instance;

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            else Destroy(this);
        }

        public static void OnLoaderCallback()
        {
            if (onLoaderCallback != null)
            {
                onLoaderCallback();
                onLoaderCallback = null;
            }
        }
    }

}