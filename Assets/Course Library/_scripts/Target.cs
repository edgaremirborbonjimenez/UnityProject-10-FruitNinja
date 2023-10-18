using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Target : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float minForce, maxForce,torqueForce,minPositionX, maxPositionX,positonY;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
        startForces();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void startForces()
    {
        _rigidbody.AddForce(Vector3.up*Random.Range(minForce,maxForce),ForceMode.Impulse);
        _rigidbody.AddTorque(Random.Range(-torqueForce,torqueForce),Random.Range(-torqueForce,torqueForce),Random.Range(-torqueForce,torqueForce),ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(minPositionX, maxPositionX), positonY);
    }

    //Al hacer clic
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sensor"))
        {
            Destroy(gameObject);
        }
    }
}
