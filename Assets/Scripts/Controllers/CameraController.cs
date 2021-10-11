using System;

using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Camera Camera;

    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private Transform Target;

    private float distance = 10.0f;

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
        Position = Target.position;
        UpdateRotation();
        UpdateZoom();
    }

    private void UpdateRotation()
    {
        if (MouseButton.Left)
        {
            Rotation = CalculateRotation();
        }
        if (MouseButton.Right)
        {
            Rotation = CalculateRotation();
            Player.transform.eulerAngles = new Vector3(0, Rotation.y - 90, 0);
        }
    }

    private void UpdateZoom()
    {
        if (Mouse.Scroll < 0)
        {
            distance = Math.Min(15.0f, distance + 1.0f);
        }
        if (Mouse.Scroll > 0)
        {
            distance = Math.Max(1.0f, distance - 1.0f);
        }
        Transform.LookAt(Target);
        Transform.Translate(new Vector3(0, 0, -distance));
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
