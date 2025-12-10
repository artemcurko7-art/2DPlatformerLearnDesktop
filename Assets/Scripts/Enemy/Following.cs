using System.Runtime.CompilerServices;
using UnityEngine;

public class Following : MonoBehaviour
{
    [SerializeField] private Transform _enemy;
    [SerializeField] private Transform _target;
    [SerializeField] private float _maxDistance;

    public bool IsReached { get; private set; }

    public void Move(float speed)
    {
        if (Vector3.Distance(_target.position, _enemy.position) > _maxDistance)
        {
            _enemy.position = Vector3.MoveTowards(_enemy.position, _target.position, speed * Time.deltaTime);
            IsReached = false;
            Debug.Log("Следование");
        }
        else
        {
            Debug.Log("Достиг цели");
            IsReached = true;
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.TryGetComponent<Player>(out Player player))
    //    {
    //        IsReached = true;
    //    }
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.TryGetComponent<Player>(out Player player))
    //    {
    //        IsReached = false;
    //    }
    //}
}
