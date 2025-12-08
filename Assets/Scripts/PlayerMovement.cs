using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerJump _playerJump;
    [SerializeField] private float _speed;

    private readonly int _directionRight = 1;
    private readonly int _directionLeft = -1;
    private readonly string _isRun = "IsRun";

    public void MoveRight() =>
        Move(_directionRight, false);

    public void MoveLeft() =>
        Move(_directionLeft, true);

    private void Move(float direction, bool isFlixX)
    {
        if (_playerJump.IsJump())
        {
            _player.Rigidbody2D.velocity = GetDirection(direction, _speed);
            _player.SpriteRenderer.flipX = isFlixX;
            _player.Animator.SetBool(_isRun, true);
        }
    }

    private Vector2 GetDirection(float direction, float speed) =>
        new Vector2(direction * speed, 0);
}
