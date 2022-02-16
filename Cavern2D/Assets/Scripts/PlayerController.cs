using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private LayerMask setLayerMask;
    private Rigidbody2D rigidBody2d;
    private BoxCollider2D boxCollider2d;
    private float moveInput;
    public float speed = 14f;
    bool doubleJump;
    private Animator animator;

    // Start is called before the first frame update.

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody2d = GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();

    }




    // Players movement mechanics. with jumpVelocity you can change and adjust height of the jump.
    // Animator variables runs sprite animations when jumping, running, falling etc.

    private void Update()
    {

        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        moveInput = Input.GetAxis("Horizontal");
        rigidBody2d.velocity = new Vector2(moveInput * speed, rigidBody2d.velocity.y);

        if (isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 25f;
            rigidBody2d.velocity = Vector2.up * jumpVelocity;
            doubleJump = true;

        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            if (doubleJump)
            {
                float jumpVelocity = 20f;
                rigidBody2d.velocity = Vector2.up * jumpVelocity;
                doubleJump = false;

            }
        }
    }


    // isGrounded prevents you from jumping while in air. You can jump again only when you've landed.
    // Only way to jump while in air is by doubleJumping.


    private bool isGrounded()
    {
        RaycastHit2D rayCastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, setLayerMask);
        Debug.Log(rayCastHit2d.collider);
        return rayCastHit2d.collider != null;

    }
}



