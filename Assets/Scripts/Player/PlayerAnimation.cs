using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;

    private readonly string _run = "IsRun";

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _inputReader.Idled += OnIdledAnimation;
        _inputReader.Movable += OnMovableAnimation;
    }

    private void OnDisable()
    {
        _inputReader.Idled -= OnIdledAnimation;
        _inputReader.Movable -= OnMovableAnimation;
    }

    private void OnIdledAnimation() =>
        _animator.SetBool(_run, false);

    private void OnMovableAnimation(float direction) =>
        _animator.SetBool(_run, true);
}