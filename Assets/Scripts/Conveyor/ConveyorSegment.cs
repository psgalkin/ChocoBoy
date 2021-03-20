using System.Collections;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorSegment : MonoBehaviour
{
    private Rigidbody _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    public void StartMove(float speed)
    {
        //_rigidBody = GetComponent<Rigidbody>();
        _rigidBody.velocity = Vector3.forward * speed;
    }

    public void GoDown(float downAngle)
    {
        _rigidBody.transform.Rotate(new Vector3(0f, 0f, downAngle));
    }

    public void StopMove()
    {
        _rigidBody.velocity = Vector3.zero;
    }

    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
