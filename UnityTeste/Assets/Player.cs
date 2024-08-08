using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    float moveForce;
    float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Move()
    {
        rigidbody2D.velocity = new Vector2(moveForce, 0);
    }
    private void jump()
    {
        rigidbody2D.velocity = new Vector2(0, jumpForce);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveForce = -5;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            moveForce = 5;
        }
        else
        {
            moveForce = 0;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            jumpForce = 5;
            jump();

        }

        Move();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

}
