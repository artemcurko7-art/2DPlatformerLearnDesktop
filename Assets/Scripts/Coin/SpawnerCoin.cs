using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SpawnerCoin : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private float _repeatRate;
    [SerializeField] private int _capacityPool;
    [SerializeField] private int _maxSizePool;
    
    private ObjectPool<Coin> _pool;

    private void Awake()
    {
        _pool = new ObjectPool<Coin>(
            createFunc: () => Instantiate(_coin),
            actionOnGet: (coin) => ActionOnGet(coin),
            actionOnRelease: (coin) => ActionOnRelease(coin),
            actionOnDestroy: (coin) => Destroy(coin.gameObject),
            defaultCapacity: _capacityPool,
            maxSize: _maxSizePool);
    }

    private void Start()
    {
        StartCoroutine(SpawnCoin());
    }

    private void ActionOnGet(Coin coin)
    {

    }

    private void ActionOnRelease(Coin coin)
    {

    }

    private void GetCoin()
    {
        _pool.Get();
    }

    private IEnumerator SpawnCoin()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(_repeatRate);

            
        }
    }
}
