using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    void Update() => transform.Rotate(Vector3.up * (5f * Time.deltaTime));
}
