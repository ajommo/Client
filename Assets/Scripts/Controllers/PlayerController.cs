using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;

    private void Start()
    {
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
        var speed = 0.0f;
        var move = new Vector3();
        if (Input.GetKey(KeyCode.D))
        {
            if (MouseButton.Right)
            {
                speed = 0.14f;
                move -= new Vector3(0.0f, 0.0f, 0.14f);
            }
            else
            {
                Player.transform.Rotate(new Vector3(0.0f, 3.6f, 0.0f));
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (MouseButton.Right)
            {
                speed = 0.14f;
                move += new Vector3(0.0f, 0.0f, 0.14f);
            }
            else
            {
                Player.transform.Rotate(new Vector3(0.0f, -3.6f, 0.0f));
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            speed = 0.14f;
            move += new Vector3(0.14f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            speed = 0.08f;
            move -= new Vector3(0.08f, 0.0f, 0.0f);
        }
        if (move.magnitude > speed)
        {
            move = move.normalized * speed;
        }
        Player.transform.Translate(move);
    }
}
