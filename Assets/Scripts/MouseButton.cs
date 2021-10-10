using UnityEngine;

public static class MouseButton
{
    public static bool Left => Input.GetMouseButton(0);
    public static bool Right => Input.GetMouseButton(1);
}