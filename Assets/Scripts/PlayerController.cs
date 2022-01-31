using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private LayerMask setLayerMask;
    private Rigidbody2D rigidBody2d;
    private BoxCollider2D boxCollider2d;
    private float moveInput;
    private float speed = 14f;




    // Start is called before the first frame update.

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigidBody2d = GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();

    }




    // Spriten hyppy ja liikkumis mekaniikat. jumpVelocitylla voidaan saataa hypyn korkeutta
    // Animator muuttujilla saadaan spriten juoksu, hyppy ja tippumis animaatiot toimimaan


    public Animator animator;

    private void Update()
    {

        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));   

        moveInput = Input.GetAxis("Horizontal");
        rigidBody2d.velocity = new Vector2(moveInput * speed, rigidBody2d.velocity.y);

        if (SpriteGround() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 32f;
            rigidBody2d.velocity = Vector2.up * jumpVelocity;


            // Asettaa Verticalin animointiin.

            animator.SetFloat("Vertical", rigidBody2d.velocity.y);


        }
    }


    // SpriteMaassa estaa hyppaamisen jos olet ilmassa, eli pystyt hyppaamaan uusiksi vasta kun olet laskeutunut.


    private bool SpriteGround()
    {
        RaycastHit2D rayCastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, setLayerMask);
        Debug.Log(rayCastHit2d.collider);
        return rayCastHit2d.collider != null;

    }
}



