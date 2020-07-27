using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables
    Animator animator;
    Rigidbody2D rigidBody;
    SpriteRenderer spriteRenderer;

    bool isGrounded;

    //SerializeField is essentially the Unity equivalent of the EditAnywhere UPROPERTY in Unreal Engine
    [SerializeField, Tooltip("Checks whether or not the player is currently touching the ground.")]
    Transform groundCheck;
    float radius = 0.5f;


    [SerializeField, Tooltip("Max speed, in units per second, that the character moves.")]
    private float runningSpeed;

    [SerializeField, Tooltip("How hard the player can jump")]
    private float jumpForce;
    // [SerializeField, Tooltip("Acceleration while grounded.")]
    // private int groundAcceleration;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        //Ground check
        //isGrounded = Physics2D.OverlapCircle(groundCheck.position, radius, 1 << LayerMask.NameToLayer("Ground"));
        if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        //Handling input for movement
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rigidBody.velocity = new Vector2(runningSpeed, rigidBody.velocity.y);
            if (isGrounded)
            {
                animator.Play("Run");
            }
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rigidBody.velocity = new Vector2(-1 * runningSpeed, rigidBody.velocity.y);
            if (isGrounded)
            {
                animator.Play("Run");
            }
            spriteRenderer.flipX = true;
        }
        else
        {
            if (isGrounded)
            {
                animator.Play("Idle");
            }
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y); //ensures the player comes to a complete stop once the button is released
        }

        //Handling vertical movement
        if (Input.GetKey("space") && isGrounded)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
            animator.Play("Jump"); 
        }
    }
}
