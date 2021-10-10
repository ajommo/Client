using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Camera Camera;

    [SerializeField]
    private GameObject Player;

    private Transform Transform
    {
        get => Camera.transform;
    }

    private Vector3 Position
    {
        set => Transform.position = value;
    }

    private Vector3 Rotation
    {
        get => Transform.eulerAngles;
        set => Transform.eulerAngles = value;
    }

    private void Update()
    {
        Position = Player.transform.position;
        if (MouseButton.Left)
        {
            Rotation = CalculateRotation();
        }
        if (MouseButton.Right)
        {
            Rotation = CalculateRotation();
            Player.transform.eulerAngles = new Vector3(0, Rotation.y - 90, 0);
        }
        Transform.LookAt(Player.transform);
        Transform.Translate(new Vector3(0, 0, -10));
    }

    private Vector3 CalculateRotation()
    {
        var x = Rotation.x - Mouse.DeltaY * 10.0f;
        var y = Rotation.y + Mouse.DeltaX * 10.0f;
        if (x > 90.0f && x < 180.0f)
        {
            x = 90.0f;
        }
        if (x < 270.0f && x > 180.0f)
        {
            x = 270f;
        }
        return new Vector3(x, y);
    }
}
