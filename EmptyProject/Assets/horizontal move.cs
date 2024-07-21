using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalmove : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D Rb;
    public float speed = 5;
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Rb.velocity = new Vector2(moveHorizontal * speed, Rb.velocity.y);

    }
}
