using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
       public float speed = 5.0f;
    public float jumpForce = 5.0f; // Adjustable jump force
    private Animator animator;
    public bool controlEnabled = true;
    bool isGrounded = true; // Track grounded state
    bool jump;


    void Start()
    {
        animator = GetComponent<Animator>(); //bắt đầu animation khép mở chân
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        bool isMoving = moveHorizontal != 0; // khai báo biến isMoving
        animator.SetBool("isMoving", isMoving);

        if (isMoving) // nếu nhân vật đang di chuyển
        {
            transform.position += new Vector3(moveHorizontal * speed * Time.deltaTime, 0f, 0f);
        }
        jump = Input.GetKeyDown(KeyCode.Space); // Jump input on Space key press
        if (jump && isGrounded && controlEnabled)
        {
            // GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            transform.position += new Vector3(moveHorizontal * speed * Time.deltaTime, 0f, 0f);
            jumpCount++;
            isGrounded = false; // Set to false to prevent double jumps
            // animator.SetTrigger("Jump"); // Trigger jump animation (if applicable)
        }

    }
}