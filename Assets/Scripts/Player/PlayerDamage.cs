using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private Character_Base _playerData;
    
    private int _health;
    
    private bool _canBeDamaged;
    
    private float _timer;
    private float _invincibilityTime = 2f;


    void Start()
    {
        _health = _playerData.characterHealth;
        _timer = 0f;
        _canBeDamaged = true;

    }

    private void Update()
    {
        if(_timer == 0f && _canBeDamaged == false)
        {
            _timer += Time.fixedDeltaTime;
        }
        if(_timer < _invincibilityTime && _timer != 0)
        {
            _timer += Time.fixedDeltaTime;
        }
        if(_timer >= _invincibilityTime)
        {
            _canBeDamaged = true;
            _timer = 0f;
        }

        if(_health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") || collision.CompareTag("DiffEnemy") && _canBeDamaged == true)
        {
            _canBeDamaged = false;
            print("Took DMg");
            _health-= 1;
        }
    }
   
}
