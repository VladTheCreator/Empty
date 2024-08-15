using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    [SerializeField] private float lifetime;
    void Start()
    {
        Invoke("Destroy", lifetime);
    }
    void Destroy()
    {
        Destroy(gameObject);
    }
}

