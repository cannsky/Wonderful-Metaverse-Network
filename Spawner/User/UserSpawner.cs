using UnityEngine;
using Photon.Pun;

namespace WonderfulMetaverseNetwork.Spawner.User
{
    public class UserSpawner
    {
        public static void SpawnUsers(GameObject gameObject, GameObject spawnPoint)
        {
            PhotonNetwork.Instantiate(gameObject.name, spawnPoint.transform.position, Quaternion.identity);
        }
    }
}