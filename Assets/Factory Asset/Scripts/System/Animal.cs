using System;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

[RequireComponent(typeof(CharacterController))]
public abstract class Animal : MonoBehaviour
{
    public float m_Speed { get; set; }
    protected abstract float defaultSpeed { get; }
    public float m_JumpHeight { get; set; }
    protected abstract float defaultJumpHeight { get; }

    private float gravityValue = -9.81f;
    CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    void Awake()
    {
        m_Speed = defaultSpeed;
        m_JumpHeight = defaultJumpHeight;
    }

    void Start()
    {
        controller = GetComponent<CharacterController>();
        CheckActiveAnimal();
    }

    void Update()
    {
        CheckGrounded();
        Move();
        Jump();
    }

    private void CheckGrounded()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
    }

    private void Jump()
    {
        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(m_JumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    private void Move()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * m_Speed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }

    protected abstract void CheckActiveAnimal();
}
