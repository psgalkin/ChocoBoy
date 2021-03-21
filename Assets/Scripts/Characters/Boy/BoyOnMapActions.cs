using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BoyOnMapActions : MonoBehaviour
{
    private RaycastHit _hit;
    private NavMeshAgent _agent;
    private bool _goForChocolate;
    private GameObject _targetChocolate;
    private BoyController _boyController;
    private Rigidbody _rb;
    
    private void Awake()
    {
        _goForChocolate = false;
        _agent = GetComponent<NavMeshAgent>();
        _boyController = GetComponent<BoyController>();
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //if (Math.Abs(_rb.velocity.magnitude) > 0.01f)
         //   _boyController.IsRun = true;
        //else
        //    _boyController.IsRun = false;

        if (_goForChocolate)
        {
            if (_targetChocolate == null)
                _goForChocolate = false;
             //сравнивать по х и у
            else if (Math.Abs(transform.position.magnitude - _targetChocolate.transform.position.magnitude) < 0.9f)
            {
                 Chocolate chocolate = _targetChocolate.GetComponent<Chocolate>();
                 _boyController.OnTakeChocolate(chocolate);
                 chocolate.OnDestroy();
                 _goForChocolate = false; 
            }
            else 
                _agent.SetDestination(_targetChocolate.transform.position);
        }
        
        if (!Input.GetMouseButton(0)) return;
        
        _boyController.StartMove();
        var r = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(r, out _hit);
        
        if (_hit.transform.CompareTag("Chocolate"))
        {
            _targetChocolate = _hit.transform.gameObject;
            _agent.SetDestination(_hit.transform.position);
            Debug.Log("Chocolate!");
            _goForChocolate = true;
        }

        else
        {
            _agent.SetDestination(_hit.point);
            _goForChocolate = false;
        }
    }
}
