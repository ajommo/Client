using UnityEngine;

public static class Mouse
{
    public static float X => Input.mousePosition.x;
    public static float Y => Input.mousePosition.y;
    public static float Z => Input.mousePosition.z;

    public static float DeltaX => Input.GetAxis("Mouse X");
    public static float DeltaY => Input.GetAxis("Mouse Y");

    public static float Scroll => Input.GetAxis("Mouse ScrollWheel");
}
