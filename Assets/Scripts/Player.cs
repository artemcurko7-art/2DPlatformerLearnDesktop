using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer), typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private PlayerWallet _playerWallet;

    public Rigidbody2D Rigidbody2D { get; private set; }
    public SpriteRenderer SpriteRenderer { get; private set; }
    public Animator Animator { get; private set; }

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        Animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.TryGetComponent<Coin>(out Coin coin))
        {
            _playerWallet.AddCoin(coin);
        }
    }
}
