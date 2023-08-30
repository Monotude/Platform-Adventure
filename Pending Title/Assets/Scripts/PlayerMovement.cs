using System;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float verticalMovement;
    private float horizontalMovement;
    [SerializeField] private float movementSpeed;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask ground;
    [SerializeField] private float jumpForce;
    [SerializeField] private AudioSource jumpSound;

    public float MovementSpeed { get => movementSpeed; set => movementSpeed = value; }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        verticalMovement = Input.GetAxis("Vertical");
        horizontalMovement = Input.GetAxis("Horizontal");
        Vector3 velocity = (Camera.main.transform.forward * verticalMovement) + (Camera.main.transform.right * horizontalMovement);
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
