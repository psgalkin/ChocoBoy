using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyController : MonoBehaviour
{
    [SerializeField] private InGameUi _inGameUi;

    private BoyAnimation _boyAnimation;
    private CurrencyController _currencyController;
    private BoyState _boyState;
    public bool IsRun;

    private void Awake()
    {
        _currencyController = GetComponent<CurrencyController>();
    }

    private void Start()
    {
        _boyAnimation = GetComponent<BoyAnimation>();
        _boyState = BoyState.Ilde;
    }

    public void StartMove()
    {
        _boyState = BoyState.OnMoving;
    }

    public void SetState(BoyState state)
    {
        _boyState = state;
    }
    
    public void OnTakeChocolate(Chocolate chocolate)
    {
        _boyAnimation.StopMove();
        
        if (chocolate.Type == ChocolateType.Chocolate || chocolate.Type == ChocolateType.Rafaello ||
            chocolate.Type == ChocolateType.Truffele)
        {
            _currencyController.AddChocolate(chocolate);
            _boyState = BoyState.OnStartTakeChocolate;
        } 
        else if (chocolate.Type == ChocolateType.Dirt || chocolate.Type == ChocolateType.Nails ||
             chocolate.Type == ChocolateType.Glass || chocolate.Type == ChocolateType.Shit)
        {
            _currencyController.AddScum(chocolate);
            _boyState = BoyState.OnStartTakeScum;
        }    
    }
    
    
    private void FixedUpdate()
    {
        OnStartUpdate();
        
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
        _boyAnimation.TakeScum();
        _boyState = BoyState.OnTaking;
    }

    private void OnStopTakeChocolate()
    {
        _boyState = BoyState.Ilde;
    }

    private void OnStartTakeChocolate()
    {
        _boyAnimation.TakeChocolate();
        _boyState = BoyState.OnTaking;
    }

    private void OnStopMove()
    {
        _boyState = BoyState.Ilde;
    }

    private void OnStartMove()
    {
        _boyAnimation.StartMove();
        _boyState = BoyState.OnMoving;
    }



    private void OnStartUpdate()
    {
        _inGameUi.SetChocolate(_currencyController.GetChocolateVal());
        _inGameUi.SetScum(_currencyController.GetScumVal());
        //if (IsRun)
        Debug.Log("onstartUpdate");
        _boyAnimation.StartMove();
        //else _boyAnimation.StopMove();
    }

    private void OnLevelWin()
    {
        
    }
    private void OnLevelLoss()
    {
        
    }
    
}
