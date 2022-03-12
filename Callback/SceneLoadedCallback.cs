using UnityEngine;
using WonderfulMetaverseNetwork.Spawner.User;
using WonderfulMetaverseNetwork.Manager.Sub.Callback;

namespace WonderfulMetaverseNetwork.Callback
{
    public class SceneLoadedCallback : MonoBehaviour
    {

        public GameObject spawnPoint;
        public GameObject userModel;

        private void Awake()
        {
            SceneCallbackManager.onLoaderCallback = () =>
            {
                UserSpawner.SpawnUsers(userModel, spawnPoint);
            };
        }

        private void Start() => SceneCallbackManager.OnLoaderCallback();
    }
}