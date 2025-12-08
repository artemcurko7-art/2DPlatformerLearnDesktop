using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), (typeof(SpriteRenderer)))]
public class Enemy : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D { get; private set; }
    public SpriteRenderer SpriteRenderer { get; private set; }

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
}
