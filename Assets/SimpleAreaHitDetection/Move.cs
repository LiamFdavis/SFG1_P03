using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 5f;
    [SerializeField] float _turnSpeed = 20f;
    Rigidbody _rb = null;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        MoveTank();
        TurnTank();

    }
    private void MoveTank()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * _moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * _moveSpeed;
        }
    }

    private void TurnTank()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,Time.deltaTime * -_turnSpeed,0, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, Time.deltaTime * _turnSpeed, 0, Space.Self);
        }
    }
}
