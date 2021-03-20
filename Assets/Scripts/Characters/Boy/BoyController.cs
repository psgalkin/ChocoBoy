using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyController : MonoBehaviour
{
    private Rigidbody _rigigbody;
    private BoyState _boyState;


    private void Start()
    {
        _rigigbody = GetComponent<Rigidbody>();
        _boyState = BoyState.Ilde;
    }

    private void Update()
    {
        switch(_boyState)
        {
            case BoyState.Ilde:
                break;
            case BoyState.OnStartMove:
                OnStartMove();
                break;
            case BoyState.OnMoving:
                break;
            case BoyState.OnStopMove:
                OnStopMove();
                break;
            case BoyState.OnStartTakeChocolate:
                OnStartTakeChocolate();
                break;
            case BoyState.OnTaking:
                break;
            case BoyState.OnStopTakeChocolate:
                OnStopTakeChocolate();
                break;
            case BoyState.OnStartTakeScum:
                OnStartTakeScum();
                break;
            case BoyState.OnStopTakeScum:
                OnStopTakeScum();
                break;
            case BoyState.None:
                break;
            default:
                break;
        }

    }

    private void OnStopTakeScum()
    {
        _boyState = BoyState.Ilde;
    }

    private void OnStartTakeScum()
    {
        _boyState = BoyState.OnTaking;
    }

    private void OnStopTakeChocolate()
    {
        _boyState = BoyState.Ilde;
    }

    private void OnStartTakeChocolate()
    {
        _boyState = BoyState.OnTaking;
    }

    private void OnStopMove()
    {
        _boyState = BoyState.Ilde;
    }

    private void OnStartMove()
    {
        _boyState = BoyState.OnMoving;
    }
}
