using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;

    [SerializeField] private Gun_Base _gun;

    private int _numBullets;
    private int _damageVal;

    private float _bulletSpeed;
    private float _angleOfFire;
    private float _timeBtwnShots;
    private float _timer;

    private bool _canShoot;

    private Camera _camera;

    private Vector3 _mouseDirection;

    void Start()
    {
        _camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        _timer = 0f;
        _mouseDirection = Vector2.zero;
        _numBullets = _gun.numBullets;
        _bulletSpeed = _gun.bulletSpeed;
        _angleOfFire = _gun.angleOfFire;
        _damageVal = _gun.damageVal;
        _timeBtwnShots = _gun.timeBtwnShots;
    }

    private void Update()
    {
        _mouseDirection = _camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = _mouseDirection - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
    void FixedUpdate()
    {
        CheckFire();
    }

    private void CheckFire()
    {
        if (_timer == 0)
        {
            _canShoot = true;
        }
        if (_canShoot == true)
        {
            Fire();
            _canShoot = false;
        }
        if (_canShoot == false)
        {
            _timer += Time.fixedDeltaTime;
        }
        if (_timer >= _timeBtwnShots)
        {
            _timer = 0;
        }
    }

    private void Fire()
    {
        if (_canShoot == true && Input.GetButton("Fire1"))
        {
            GameObject bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
            
        }
        _canShoot = false;
    }
}
