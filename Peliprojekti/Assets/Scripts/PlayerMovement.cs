using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float jumpForce;
    private float moveInput;

    [HideInInspector]
    public Rigidbody2D rb;
    
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public int extraJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);



    }

    // Update is called once per frame
    void FixedUpdate()
    {

        moveInput = Input.GetAxis("Horizontal");
        //Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        /*if (extraJump == 0)
        {
            isGrounded = true;
        }*/
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump == 2 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJump--;
            isGrounded = false;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump == 1)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJump--;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        extraJump = 2;

        if (collision.gameObject.tag.Equals("Platform"))
        {
            this.transform.parent = collision.transform;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals ("Platform"))
        {
            this.transform.parent = null;
        }
    }
}
