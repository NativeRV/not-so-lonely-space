using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using UnityEngine.InputSystem;

namespace NSLS.Game.Input
{
  public class PlayerMovementController : NetworkBehaviour
  {
    [Header("Player stats")]
    [SerializeField]
    private float moveSpeed = 5;

    [SerializeField]
    private float jumpHeight = 1.5f;

    [SerializeField]
    private float gravity = 1f;
    private float Gravity { get { return -gravity * 0.01f; } }

    [SerializeField]
    private CharacterController characterController;

    [SerializeField]
    private LayerMask playerGroundMask;

    [SerializeField]
    private Transform playerGroundPoint;

    private bool isGrounded = false;
    private bool currentJumpInput;
    private Vector2 currentHorizontalInput;
    private Vector3 verticalVelocity = Vector3.zero;

    private Controls controls;
    private Controls Controls
    {
      get
      {
        // Инициализируем систему инпута или реюзаем имеющуюся
        if (controls != null) return controls;

        controls = new Controls();
        return controls;
      }
    }

    public void Start()
    {
      // enabled = true;

      Controls.Player.PlayerHorizontalMovement.performed += (ctx) => SetMovement(ctx.ReadValue<Vector2>());
      Controls.Player.PlayerHorizontalMovement.canceled += (ctx) => ResetMovement();

      Controls.Player.PlayerJump.performed += (ctx) => SetJumping(true);
      Controls.Player.PlayerJump.canceled += (ctx) => ResetJumping();
    }

    private void OnEnable()
    {
      Controls.Enable();
    }

    private void OnDisable()
    {
      Controls.Disable();
    }

    void SetMovement(Vector2 inputVector)
    {
      currentHorizontalInput = inputVector;
    }

    void ResetMovement()
    {
      currentHorizontalInput = Vector2.zero;
    }

    void SetJumping(bool inputBoolean)
    {
      currentJumpInput = true;
    }

    void ResetJumping()
    {
      currentJumpInput = false;
    }


    void UpdateMovement()
    {
      if (!IsLocalPlayer) return;


      Vector3 sideAxis = transform.right;
      Vector3 forwardAxis = transform.forward;

      sideAxis.y = 0f;
      forwardAxis.y = 0f;

      Vector3 movement = sideAxis.normalized * currentHorizontalInput.x +
                        forwardAxis.normalized * currentHorizontalInput.y;

      var horizontalVelocity = movement * moveSpeed * Time.deltaTime;

      characterController.Move(horizontalVelocity);
      characterController.Move(verticalVelocity);
    }

    void UpdateGrounded()
    {
      // Чекаем троганье земли
      isGrounded = Physics.CheckSphere(playerGroundPoint.position, 0.1f, playerGroundMask);
      // isGrounded = Physics.Raycast(playerGroundPoint.position, Vector3.down, 3f, playerGroundMask);
    }

    void UpdateGravity()
    {
      verticalVelocity.y += Gravity;

      if (isGrounded && verticalVelocity.y < 0)
      {
        // Оставляем немного скорости, чтобы убедиться в том что игрок трогает землю
        verticalVelocity.y = -0.1f;
      }

    }

    void UpdateJump()
    {
      // if (!currentJumpInput) return;
      // if (!isGrounded) return;

      // verticalVelocity.y = Mathf.Sqrt(-2f * jumpHeight * gravity);
      if (isGrounded && currentJumpInput)
      {
        verticalVelocity.y = Mathf.Sqrt(-2f * jumpHeight * Gravity);
      }
      // characterController.Move(Vector3.up * 10);
    }

    void Update()
    {
      UpdateGrounded();
      UpdateJump();
      UpdateGravity();

      UpdateMovement();

      Debug.Log(new { isGrounded, currentJumpInput, verticalVelocity, gravityDelta = 0.5f * gravity * Mathf.Pow(Time.deltaTime, 2) });
    }
  }
}