using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _groundedPoint;
    [SerializeField] private LayerMask _groundedMask;
    [SerializeField] private float _distanceRay;
    [SerializeField] private float _jumpForce;

    public void Jump()
    {
        if (IsJump())
            _player.Rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    public bool IsJump() =>
        (Physics2D.Raycast(_groundedPoint.position, -Vector2.up, _distanceRay, _groundedMask));
}
