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
        Vector2 mousePositionScreenCoordinates = Input.mousePosition;
        Vector2 mousePositionGameCoordinates = Camera.main.ScreenToWorldPoint(mousePositionScreenCoordinates);
        Vector2 mouseDirection = mousePositionGameCoordinates - (Vector2)transform.position;
        transform.eulerAngles = new Vector3(0, 0, Vector2.SignedAngle(transform.position, mouseDirection));
        if (Input.GetKey(KeyCode.Space) && Time.time >= timeToShoot)
        {
            GameObject BulletInstance = Instantiate(Bullet);
            BulletInstance.transform.position = ShotingPoint.transform.position;
            BulletInstance.GetComponent<BulletShoot>().SetDirection(mouseDirection.normalized);
            timeToShoot = Time.time + cooldown;
        }
    }
}
