﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
  public float runSpeed = 0.6f; // Running speed.
  public float jumpForce = 2.6f; // Jump height.

  private Rigidbody2D body; // Variable for the RigidBody2D component.
  private SpriteRenderer sr; // Variable for the SpriteRenderer component.
  private Animator animator; // Variable for the Animator component. [OPTIONAL]

  private bool isGrounded; // Variable that will check if character is on the ground.
  public LayerMask groundLayer; // Layer wich the character can jump on.

  private bool jumpPressed = false; // Variable that will check is "Space" key is pressed.
  private bool APressed = false; // Variable that will check is "A" key is pressed.
  private bool DPressed = false; // Variable that will check is "D" key is pressed.
    private bool _walking;

    public AudioSource moveSound;
    public AudioSource jumpSound;
  
  private Vector2 respawnPosition;
    public void Respawn(){
        transform.position = respawnPosition;
    }
    public void SetRespawnPosition(Vector2 Position){
        respawnPosition = Position;
    }
  void Awake() {
    body = GetComponent<Rigidbody2D>(); // Setting the RigidBody2D component.
    sr = GetComponent<SpriteRenderer>(); // Setting the SpriteRenderer component.
    animator = GetComponent<Animator>(); // Setting the Animator component. [OPTIONAL]
  }

  // Update() is called every frame.
  void Update() {
        if (Input.GetKey(KeyCode.A))
        { APressed = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            DPressed = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jumpSound.Play();
        }

        if (!_walking && Input.GetAxisRaw("Horizontal") != 0)
        {
            _walking = true;
            moveSound.Play();
        }
        if (_walking && Input.GetAxisRaw("Horizontal") == 0)
        {
            _walking=false;
            moveSound.Stop();
        }
  }

  // Update using for physics calculations.
  void FixedUpdate() {    
      // Left/Right movement.
      if (APressed) {
          body.velocity = new Vector2(-runSpeed, body.velocity.y); // Move left physics.
          transform.eulerAngles = new Vector3(transform.eulerAngles.x, 180, transform.eulerAngles.z); // Rotating the character object to the left.
          APressed = false;
      }
      else if (DPressed) {
          body.velocity = new Vector2(runSpeed, body.velocity.y); // Move right physics.
          transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, transform.eulerAngles.z); // Rotating the character object to the right.
          DPressed = false; // Returning initial value.
        }
      else body.velocity = new Vector2(0, body.velocity.y);
     
  }
   void PlaySound()
    {
        moveSound.Play();
    }
}