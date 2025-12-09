using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Transform _groundedPoint;
    [SerializeField] private LayerMask _groundedMask;
    [SerializeField] private float _distanceRay;
    [SerializeField] private float _jumpForce;

    public void Jump(Rigidbody2D rigidbody2D)
    {
        if (IsGrounded())
            rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    public bool IsGrounded() =>
        (Physics2D.Raycast(_groundedPoint.position, -Vector2.up, _distanceRay, _groundedMask));
}
