using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D Rb;
    public float speed = 5;
    public float jumpForce = 5;
    public bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Rb.velocity = new Vector2(moveHorizontal * speed, Rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            Rb.AddForce(Vector2.up * jumpForce);

        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("above the ground");
            canJump = false;
        }
    }
}

