using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoyAnimation : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        
    }

    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    public void StartMove()
    {
        Debug.Log("onStartMethod");
        _animator.SetBool("Moving", true);
    }

    public void StopMove()
    {
        //_animator.SetBool("Moving", false);
    }

    public void TakeChocolate()
    {
        _animator.SetTrigger("TakeChocolate");
    }

    public void TakeScum()
    {
        _animator.SetTrigger("TakeScum");
    }
}
