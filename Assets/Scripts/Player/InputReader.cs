using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const KeyCode ButtonD = KeyCode.D;
    private const KeyCode ButtonA = KeyCode.A;
    private const KeyCode ButtonSpace = KeyCode.Space;

    public event Action<float> Movable;
    public event Action Jumper;
    public event Action Idled;

    private readonly string _horizontal = "Horizontal";

    private void Update()
    {
        if (Input.GetKey(ButtonD))
            Movable?.Invoke(Input.GetAxis(_horizontal));
        else if (Input.GetKey(ButtonA))
            Movable?.Invoke(Input.GetAxis(_horizontal));
        else if (Input.GetAxis(_horizontal) == 0)
            Idled?.Invoke();    

        if (Input.GetKeyDown(ButtonSpace))
            Jumper?.Invoke();
    }
}
