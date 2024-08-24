using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHorizontal : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Bounds bounds;
    void Update()
    {
        if (bounds.InHorizontalBounds())
        {
            Move();
        }
    }
    protected void Move()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0);
    }
}
