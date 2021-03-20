using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoyAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    void Start()
    {
        
    }

    public void StartMove()
    {
        _animator.SetBool("Moving", true);
    }

    public void StopMove()
    {
        _animator.SetBool("Moving", false);
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
