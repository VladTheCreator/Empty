using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotation;
    private Vector3 _direction;

    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }

    void Update()
    {
        transform.position += _direction * speed * Time.deltaTime;
    }
}
