using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    PlayerStats playerStats;
    private Vector2 moveDirection;
    private bool isMoving;
    public bool isFacingRight = false;
    private Rigidbody2D rb;
    private float playerSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerStats = GetComponent<PlayerStats>();
        playerSpeed = playerStats.GetSpeed();
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        if (horizontalInput == -1)
        {
            transform.localScale = new Vector2(1f,transform.localScale.y);
            isFacingRight = false;
        }else if (horizontalInput == 1)
        {
            transform.localScale = new Vector2(-1f,transform.localScale.y);
            isFacingRight = true;
        }
        verticalInput = Input.GetAxisRaw("Vertical");
        isMoving = horizontalInput != 0 || verticalInput != 0;
        moveDirection = new Vector2(horizontalInput, verticalInput).normalized * playerSpeed;
    }
    void FixedUpdate()
    {
        if (!isMoving)
        {
            rb.velocity = Vector2.zero;
        }
        rb.velocity = moveDirection;
    }
}
