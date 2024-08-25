using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHorizontal : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Bounds bounds;
    void Update()
    {
        if (bounds.InRightHorizontalBound())
        {
            Move();
        }
        else // !bounds.InRightHorizontalBound()
        {
            //if crossed the right bound move only to the left
            MoveLeft();
        }
    }
    protected void Move()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0);
    }
    private void MoveLeft()
    {
        if (Input.GetAxis("Horizontal") < 0) // if player is pressing left arrow or "A"
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0);
        }
    }
}
