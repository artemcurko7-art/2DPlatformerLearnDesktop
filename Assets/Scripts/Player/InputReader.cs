using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public event Action<float> Movable;
    public event Action Jumper;
    public event Action Idled;

    private readonly string _horizontal = "Horizontal";

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
            Movable?.Invoke(Input.GetAxis(_horizontal));
        else if (Input.GetKey(KeyCode.A))
            Movable?.Invoke(Input.GetAxis(_horizontal));
        else if (Input.GetAxis(_horizontal) == 0)
            Idled?.Invoke();    

        if (Input.GetKeyDown(KeyCode.Space))
            Jumper?.Invoke();
    }
}
