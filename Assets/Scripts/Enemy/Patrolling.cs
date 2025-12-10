using UnityEngine;

public class Patrolling : MonoBehaviour
{
    [SerializeField] private UnitRotation _unitRotation;
    [SerializeField] private Transform _enemy;
    [SerializeField] private Transform _targetPoint;
    [SerializeField] private float _offset;

    private Vector3 _position;
    private int _direction;

    public bool IsNoticed { get; private set; }

    private void Start()
    {
        _position = GetPosition();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            IsNoticed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            IsNoticed = false;
        }
    }

    public void Move(float speed)
    {
        if (Vector3.Distance(_position, _enemy.position) <= _offset)
        {
            _position = GetPosition();
            _enemy.transform.rotation = _unitRotation.GetRotation(_direction);
        }

        _enemy.position = Vector2.MoveTowards(_enemy.transform.position, _position, speed * Time.deltaTime);
    }

    private Vector3 GetPosition()
    {
        _direction++;

        if (_direction == _targetPoint.childCount)
            _direction = 0;

        Vector3 posiiton = _targetPoint.GetChild(_direction).position;

        return posiiton;
    }
}
