using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandlerInput : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerJump _playerJump;

    private void OnEnable()
    {
        _playerInput.MovableRight += _playerMovement.MoveRight;
        _playerInput.MovableLeft += _playerMovement.MoveLeft;
        _playerInput.Jumped += _playerJump.Jump;
    }

    private void OnDisable()
    {
        _playerInput.MovableRight -= _playerMovement.MoveRight;
        _playerInput.MovableLeft -= _playerMovement.MoveLeft;
        _playerInput.Jumped -= _playerJump.Jump;
    }
}
