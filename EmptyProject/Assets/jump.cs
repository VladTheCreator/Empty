using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{

    public float jumpForce = 5;
    public bool canJump = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            Rb.AddForce(Vector2.up * jumpForce);

        }
        if (canJump == false)
        {
            GetComponent<Animator>().SetTrigger("jump");
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("above the ground");
            canJump = false;
        }
    }


}
