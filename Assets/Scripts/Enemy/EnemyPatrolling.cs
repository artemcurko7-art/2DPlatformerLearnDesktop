using Unity.VisualScripting;
using UnityEngine;

public class EnemyPatrolling : MonoBehaviour
{
    [SerializeField] private UnitRotation _unitRotation;
    [SerializeField] private Transform _targetPoint;
    [SerializeField] private float _speed;

    private Vector3 _position;
    private int _direction;

    private void Start()
    {
        _position = GetPosition();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (transform.position == _position)
        {
            _position = GetPosition();
            transform.rotation = _unitRotation.GetRotation(_direction);
        }

        transform.position = Vector2.MoveTowards(transform.position, _position, _speed * Time.deltaTime);
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
