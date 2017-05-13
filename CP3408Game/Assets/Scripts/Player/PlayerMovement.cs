using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    
    //movement
    Vector3 movement;
    Animator anim;
    Rigidbody playerRigidbody;
    
    float camRayLength = 100f;
    
    bool facingRight;

    //jumping
    bool grounded = false;
    Collider[] groundCollisions;
    float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float jumpHeight;

    void Awake()
    {
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
        facingRight = true;
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(grounded && Input.GetAxis("Jump") > 0)
        {
            grounded = false;
            anim.SetBool("grounded", grounded);
            playerRigidbody.AddForce(new Vector3(0, jumpHeight, 0));
        }

        groundCollisions = Physics.OverlapSphere(groundCheck.position, groundCheckRadius, groundLayer);
        if (groundCollisions.Length > 0) grounded = true;
        else grounded = false;

        anim.SetBool("grounded", grounded);

        float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        Move(h);

        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

        Animating(h);

        
    }

    void Move(float h)
    {
        movement.Set(h, 0f, 0f);

        movement = movement.normalized * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movement);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.z *= -1;
        transform.localScale = theScale;
    }

    void Animating(float h)
    {
        bool walking = h != 0f;
        anim.SetBool("IsWalking", walking);
    }
}
