using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public event Action<Coin> Collided;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Collided?.Invoke(this);
    }
}
