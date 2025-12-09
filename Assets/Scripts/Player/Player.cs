using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.GraphView.GraphView;

[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer))]
public class Player : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerJump _playerJump;
    [SerializeField] private UnitRotation _unitRotation;
    [SerializeField] private InputReader _inputReader;

    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        _inputReader.Movable += OnMove;
        _inputReader.Jumper += OnJump;
    }

    private void OnDisable()
    {
        _inputReader.Movable -= OnMove;
        _inputReader.Jumper -= OnJump;
    }

    private void OnMove(float direction)
    {
        _playerMovement.Move(_rigidbody2D, direction);
        transform.rotation = _unitRotation.GetRotation(direction);
    }

    private void OnJump() =>
        _playerJump.Jump(_rigidbody2D);
}
