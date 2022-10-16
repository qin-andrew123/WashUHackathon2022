using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Character_Base _playerData;

    private Vector2 _movementVec;
    private float _moveSpeed;
    private int _playerHealth; 

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _movementVec = new Vector2();
        _moveSpeed = _playerData.characterSpeed;
        _playerHealth = _playerData.characterHealth;
    }

    private void Update()
    {
        CalculateMovement();
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void CalculateMovement()
    {
        _movementVec.x = Input.GetAxisRaw("Horizontal");
        _movementVec.y = Input.GetAxisRaw("Vertical");
    }
       
    private void Move()
    {
        _rb.MovePosition(_rb.position + _movementVec * _moveSpeed * Time.fixedDeltaTime);
    }
}
