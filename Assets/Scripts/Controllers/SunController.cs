using UnityEngine;

public class SunController : MonoBehaviour
{
    [SerializeField]
    private Transform Sun;

    void Update()
    {
        Sun.Rotate(new Vector3(0.01f, 0, 0));
    }
}
