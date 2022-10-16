using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Character_Base _chargerData;

    private int _health;

    private bool _canBeDamaged;

    private float _timer;
    private float _invincibilityTime = 3f;
    void Start()
    {
        _health = _chargerData.characterHealth;
        _timer = 0f;
        _canBeDamaged = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer == 0f && _canBeDamaged == false)
        {
            _timer += Time.fixedDeltaTime;
        }
        if (_timer < _invincibilityTime && _timer != 0)
        {
            _timer += Time.fixedDeltaTime;
        }
        if (_timer >= _invincibilityTime)
        {
            _canBeDamaged = true;
            _timer = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerBullet"))
        {
            TakeDamage(1);
            Destroy(collision.gameObject);
        }
    }
    public void TakeDamage(int dmgVal)
    {
        print("health is: " + _health);
        _health -= dmgVal;
        if(_health <= 0)
        {
            ScoreMechanic.score += 1;
            Destroy(this.gameObject);
        }
    }
    
}
