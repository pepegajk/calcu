using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xod : MonoBehaviour
{
    public float speed;
    public float jumpFors;
    private float moveInput;

    private Rigidbody2D rb;
    private bool facingRight = false;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int left = 0;
    private int right = 0;



    private int extraJumps;
    public int extraJumpsValue;


    // Start is called before the first frame update
    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);





        if (left == 1)
        {
            moveInput = -1.0f;
        }
        if ((left == 0) && (right == 0))
        {
            moveInput = 0.0f;
        }
        if (right==1)
        {
            moveInput = +1.0f;
        }
       
        //moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);


        if(facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if(facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    private void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }
        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpFors;
            extraJumps--;
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    public void GoRight()
    {
        right = 1;
    }
    public void DontGoRight()
    {
        right = 0;
    }
    public void GoLeft()
    {
        left = 1;
    }
    public void DontGoLeft()
    {
        left = 0;
    }
}

