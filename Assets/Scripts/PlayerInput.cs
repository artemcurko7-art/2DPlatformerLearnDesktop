using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action MovableRight;
    public event Action MovableLeft;
    public event Action Jumped;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
            MovableRight?.Invoke();
        else if (Input.GetKey(KeyCode.A))
            MovableLeft?.Invoke();

        if (Input.GetKeyDown(KeyCode.Space))
            Jumped?.Invoke();
    }
}
