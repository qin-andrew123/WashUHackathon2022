using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _stoppingDistance;
    [SerializeField]private Character_Base _chargerData;

    private int _health;

    private float _moveSpeed;

    private Vector3 _pathToPlayer;

    void Start()
    {
        _health = _chargerData.characterHealth;
        _moveSpeed = _chargerData.characterSpeed;
    }

    void Update()
    {
        _pathToPlayer = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;
        if (_pathToPlayer.magnitude > _stoppingDistance)
        {
            _rb.MovePosition(transform.position + _pathToPlayer.normalized * _moveSpeed * Time.fixedDeltaTime);
        }
    }
}
