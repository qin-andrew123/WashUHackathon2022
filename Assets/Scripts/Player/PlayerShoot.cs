using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Gun_Base _gun;
    private int _numBullets;
    private float _bulletSpeed;
    private float _angleOfFire;
    private int _damageVal;
    private float _timeBtwnShots;
    private float _timer;

    void Start()
    {
        _timer = 0f;
        _numBullets = _gun.numBullets;
        _bulletSpeed = _gun.bulletSpeed;
        _angleOfFire = _gun.angleOfFire;
        _damageVal = _gun.damageVal;
        _timeBtwnShots = _gun.timeBtwnShots;
    }

    void Update()
    {
        
    }
}
