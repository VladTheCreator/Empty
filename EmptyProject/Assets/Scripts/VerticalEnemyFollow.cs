using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowVertical : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotation;
    void Update()
    {
        transform.position += new Vector3(0, speed * rotation * Time.deltaTime, 0);
    }
}
