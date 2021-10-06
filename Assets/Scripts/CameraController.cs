using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Camera Camera;

    [SerializeField]
    private Transform Player;

    private void Update()
    {
        Camera.transform.LookAt(Player);
    }
}
