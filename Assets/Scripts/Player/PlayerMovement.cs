using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerJump _playerJump;
    [SerializeField] private float _speed;

    public void Move(Rigidbody2D rigidbody2D, float direction)
    {
        if (_playerJump.IsGrounded())
            rigidbody2D.velocity = GetDirection(direction, _speed);
    }

    private Vector2 GetDirection(float direction, float speed) =>
        new Vector2(direction * speed, 0);
}
