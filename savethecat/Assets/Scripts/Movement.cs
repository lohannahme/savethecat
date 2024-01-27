using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float playerSpeed = 2f; // Receber velocidade do script de stats do jogador
    private Vector2 moveDirection;
    private bool isMoving;
    public bool isFacingRight = true;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        if (horizontalInput == -1)
        {
            transform.localScale = new Vector2(-1f,transform.localScale.y);
            isFacingRight = false;
        }else if (horizontalInput == 1)
        {
            transform.localScale = new Vector2(1f,transform.localScale.y);
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
