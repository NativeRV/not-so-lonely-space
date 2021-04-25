using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
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
    private float gravity = -1f;

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

    public override void OnStartAuthority()
    {
      enabled = true;

      Controls.Player.PlayerHorizontalMovement.performed += (ctx) => SetMovement(ctx.ReadValue<Vector2>());
      Controls.Player.PlayerHorizontalMovement.canceled += (ctx) => ResetMovement();

      Controls.Player.PlayerJump.performed += (ctx) => SetJumping(true);
      Controls.Player.PlayerJump.canceled += (ctx) => ResetJumping();
    }

    [ClientCallback]
    private void OnEnable()
    {
      Controls.Enable();
    }

    [ClientCallback]
    private void OnDisable()
    {
      Controls.Disable();
    }

    [Client]
    void SetMovement(Vector2 inputVector)
    {
      currentHorizontalInput = inputVector;
    }

    [Client]
    void ResetMovement()
    {
      currentHorizontalInput = Vector2.zero;
    }

    [Client]
    void SetJumping(bool inputBoolean)
    {
      currentJumpInput = true;
    }

    [Client]
    void ResetJumping()
    {
      currentJumpInput = false;
    }


    void UpdateMovement()
    {
      // if (!isLocalPlayer) return;

      // // float h = UnityEngine.Input.GetAxis("Horizontal");
      // // float v = UnityEngine.Input.GetAxis("Vertical");

      // var inputVector = horizontalMovement.ReadValue<Vector2>();

      // Vector3 dir = new Vector3(inputVector.y, 0, inputVector.x);
      // transform.position += dir.normalized * (Time.deltaTime * moveSpeed);

      Vector3 sideAxis = transform.right;
      Vector3 forwardAxis = transform.forward;

      sideAxis.y = 0f;
      forwardAxis.y = 0f;

      Vector3 movement = sideAxis.normalized * currentHorizontalInput.x +
                        forwardAxis.normalized * currentHorizontalInput.y;

      // transform.position += movement * moveSpeed * Time.deltaTime;
      // transform.position += verticalVelocity;

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
      verticalVelocity.y += -1;

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

      if (isGrounded && currentJumpInput)
      {
        verticalVelocity.y = Mathf.Sqrt(-2f * jumpHeight * gravity);
      }

      // characterController.Move(Vector3.up * 10);
    }

    [ClientCallback]
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