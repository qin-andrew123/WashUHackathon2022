using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float force;

    private Vector3 _mousePosition;
    private Vector3 _direction;

    private Camera _mainCam;
    private Rigidbody2D _rb;

    private void Start()
    {
        _mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        _rb = GetComponent<Rigidbody2D>();
        _mousePosition = _mainCam.ScreenToWorldPoint(Input.mousePosition);
        _direction = _mousePosition - transform.position;
        Vector3 rotation = transform.position - _mousePosition;
        _rb.velocity = new Vector2(_direction.x, _direction.y).normalized * force;
        Destroy(this, 3f);

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ + 90);
    }

    
}
