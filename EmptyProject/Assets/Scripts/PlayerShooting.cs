using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject ShotingPoint;
    private float timeToShoot;
    [SerializeField] private float cooldown;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&& Time.time >= timeToShoot )
        {
            
            GameObject BulletInstance = Instantiate(Bullet);
            BulletInstance.transform.position = ShotingPoint.transform.position;
            timeToShoot = Time.time + cooldown;
        }

    }
}
