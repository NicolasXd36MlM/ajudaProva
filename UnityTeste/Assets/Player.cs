using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  
    Rigidbody2D rigidbody2D;
    float moveForce;
    float jumpForce = 5f; // Valor padrão para o pulo
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Move()
    {
        rigidbody2D.velocity = new Vector2(moveForce, rigidbody2D.velocity.y);
    }

    private void Jump()
    {
        if (isGrounded)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpForce);
            isGrounded = false; // Evita pular no ar
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Movimento horizontal
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

        // Pulo
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }

        // Aplicar movimento
        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o jogador está no chão
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}



