using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
    private List<Coin> _coins = new List<Coin>();

    public event Action OnCoinChanged;

    public void AddCoin(Coin coin)
    {
        OnCoinChanged?.Invoke();
        _coins.Add(coin);
    }
}