using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyController : MonoBehaviour
{
    private float _chocolateVal;
    private float _scumVal;

    private void Awake()
    {
        _chocolateVal = 0f;
        _scumVal = 0f;
    }

    public void AddScum(Chocolate chocolate)
    {
        _scumVal += chocolate.pointsVal;
    }

    public void AddChocolate(Chocolate chocolate)
    {
        _chocolateVal += chocolate.pointsVal;
    }

    public float GetChocolateVal()
    {
        return _chocolateVal;
    }
    
    public float GetScumVal()
    {
        return _scumVal;
    }

    public void DecrementChocolateVal()
    {
        _chocolateVal--;
    }
}
