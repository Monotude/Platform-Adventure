using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float verticalMovement;
    private float horizontalMovement;
    private Camera cam;
    [SerializeField] private float movementSpeed;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask ground;
    [SerializeField] private float jumpForce;
    [SerializeField] private AudioSource jumpSound;

    public float MovementSpeed { get => movementSpeed; set => movementSpeed = value; }
    public float JumpForce { get => jumpForce; set => jumpForce = value; }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    private void Update()
    {
        verticalMovement = Input.GetAxis("Vertical");
        horizontalMovement = Input.GetAxis("Horizontal");
        Vector3 velocity = (cam.transform.forward * verticalMovement) + (cam.transform.right * horizontalMovement);
        velocity.y = 0;
        velocity = velocity.normalized;
        velocity *= MovementSpeed;
        velocity.y = rb.velocity.y;
        rb.velocity = velocity;

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            jump();
        }
    }

    private void jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        jumpSound.Play();
    }

    private bool isGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
}
