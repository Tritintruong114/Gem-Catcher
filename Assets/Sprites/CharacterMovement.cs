using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rb; // Reference to the player's rigid body
    public float jump = 15.0f;
    public float speed = 5.0f;
    public float jumpForce = 5.0f; // Adjustable jump force
    private Animator animator;
    public bool controlEnabled = true;
    bool grounded;


    void Start()
    {
        animator = GetComponent<Animator>(); //bắt đầu animation khép mở chân
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        bool isMoving = moveHorizontal != 0; // khai báo biến isMoving
        animator.SetBool("isMoving", isMoving);
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);
    
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(new Vector2(rb.velocity.x, 15 * 10));
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
    }