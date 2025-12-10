using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Patrolling _patrolling;
    [SerializeField] private Following _following;
    [SerializeField] private Attacker _attacker;
    [SerializeField] private int _health;
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;

    private void Update()
    {
        if (_patrolling.IsNoticed == false)
            _patrolling.Move(_speed);
        else
            _following.Move(_speed);

        if (_attacker.CanAttack())
        {
            Debug.Log("Можем атаковать");
        }
        //else if (_following.IsReached == false)
        //    _following.Move(_speed);
    }

    public void Attack()
    {
        Debug.Log("Attack");
    }

    public void TakeDamage(int damage)
    {
        damage -= _health;

        Die();
    }

    private void Die()
    {
        if (_health <= 0)
            Destroy(gameObject);
    }
}
