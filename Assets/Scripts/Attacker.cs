using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] private Transform _enemy;
    [SerializeField] private Transform _target;
    [SerializeField] private float _maxDistance;

    public void ApplyDamage()
    {

    }

    public bool CanAttack() =>
        Vector3.Distance(_target.position, _enemy.position) < _maxDistance;
}
