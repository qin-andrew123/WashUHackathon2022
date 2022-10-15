using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoveState
{
    LEFT,
    RIGHT,
    UP,
    DOWN,
    NO_INPUT,
}
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Rigidbody2D _rb;
    private Vector2 _movementVec;
    private MoveState _moveState = MoveState.NO_INPUT;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _movementVec = new Vector2();
    }

    private void FixedUpdate()
    {
        CalculateMovement();
        
    }

    private void CalculateMovement()
    {
            if (Input.GetKey(KeyCode.W) && _moveState != MoveState.DOWN)
            {
                _moveState = MoveState.UP;
                _movementVec.x = 0f;
                _movementVec.y = 1f;
                _rb.MovePosition(_rb.position + _movementVec * _moveSpeed * Time.fixedDeltaTime);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                _moveState = MoveState.NO_INPUT;
            }

            if (Input.GetKey(KeyCode.A) && _moveState != MoveState.RIGHT)
            {
                _moveState = MoveState.LEFT;
                _movementVec.x = -1f;
                _movementVec.y = 0f;
                _rb.MovePosition(_rb.position + _movementVec * _moveSpeed * Time.fixedDeltaTime);
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                _moveState = MoveState.NO_INPUT;
            }


            if (Input.GetKey(KeyCode.S) && _moveState != MoveState.UP)
            {
                _moveState = MoveState.DOWN;
                _movementVec.x = 0f;
                _movementVec.y = -1f;
                _rb.MovePosition(_rb.position + _movementVec * _moveSpeed * Time.fixedDeltaTime);
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                _moveState = MoveState.NO_INPUT;
            }

            if (Input.GetKey(KeyCode.D) && _moveState != MoveState.LEFT)
            {
                _moveState = MoveState.RIGHT;
                _movementVec.x = 1f;
                _movementVec.y = 0f;
                _rb.MovePosition(_rb.position + _movementVec * _moveSpeed * Time.fixedDeltaTime);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                _moveState = MoveState.NO_INPUT;
            }
        }
        
}
