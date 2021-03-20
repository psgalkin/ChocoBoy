using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chocolate : MonoBehaviour
{
    [SerializeField] public ChocolateType Type;
    [SerializeField] public float pointsVal;
    private Rigidbody _rigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rigidBody.velocity = Vector3.zero;
        _rigidBody.angularVelocity = Vector3.zero;
        transform.parent = collision.gameObject.transform;
    }

    public void OnDestroy()
    {
        
        Destroy(gameObject);
    }
}
