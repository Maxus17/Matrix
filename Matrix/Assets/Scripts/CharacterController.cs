using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController: MonoBehaviour
{
    private float speed = 200f;
    private int live = 3;
    private float jumpForce = 50f;
    private float gravity = 9.8f;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private bool isGrounded=false;

    private Vector2 respawnPosition;
    public void Respawn(){
        transform.position = respawnPosition;
    }
    public void SetRespawnPosition(Vector2 Position){
        respawnPosition = Position;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if(Input.GetButton("Horizontal"))
        {
            Run();
        }
        if(isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        ChekGrounded();
    }

    private void Run()
    {
        var dir = transform.right * Input.GetAxis("Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0f;
    }
    private void Jump()
    {
        rb.AddForce(transform.up* jumpForce, ForceMode2D.Impulse);
    }
     
    private void ChekGrounded()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
        isGrounded = collider.Length > 1;
    }
}