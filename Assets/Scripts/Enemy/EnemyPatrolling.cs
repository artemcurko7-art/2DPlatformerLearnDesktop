using UnityEngine;

public class EnemyPatrolling : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _targetPoint;
    [SerializeField] private float _speed;

    private Vector3 _position;
    private int _index;

    private void Start()
    {
        _position = GetPosition();
    }

    private void Update()
    {
        if (transform.position == _position)
        {
            _position = GetPosition();
            ChangeFlip();
        }

        transform.position = Vector2.MoveTowards(transform.position, _position, _speed * Time.deltaTime);
    }

    private Vector3 GetPosition()
    {
        _index++;

        if (_index == _targetPoint.childCount)
            _index = 0;

        Vector3 posiiton = _targetPoint.GetChild(_index).position;

        return posiiton;
    }

    private void ChangeFlip()
    {
        if (_enemy.SpriteRenderer.flipX)
            _enemy.SpriteRenderer.flipX = false;
        else
            _enemy.SpriteRenderer.flipX = true;
    }
}
