using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    [SerializeField] private float ShootSpeed;
    [SerializeField] private float rotation;

    void Update()
    {

        transform.position += new Vector3(ShootSpeed * rotation * Time.deltaTime , 0,0);
    }
}
