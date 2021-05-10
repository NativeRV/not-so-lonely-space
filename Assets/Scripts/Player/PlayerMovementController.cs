using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using UnityEngine.InputSystem;
using NSLS.Service.UnityService;

namespace NSLS.Game.Input
{
  public class PlayerMovementController : NetworkBehaviour
  {
    [Header("Player stats")]
    [SerializeField]
    public float moveSpeed = 5;

    [SerializeField]
    public float jumpHeight = 1.5f;

    [SerializeField]
    public float gravity = 1f;
    public float gravityMultiplier = 0.01f;
    public float Gravity { get => -gravity * gravityMultiplier; }

    [SerializeField]
    public CharacterController characterController;

    [SerializeField]
    public LayerMask playerGroundMask;

    [SerializeField]
    public Transform playerGroundPoint;

    public bool isGrounded = false;
    public bool currentJumpInput;
    public Vector2 currentHorizontalInput;
    public Vector3 verticalVelocity = Vector3.zero;

    public Movement Movement;

    public IUnityService UnityService;

    public Controls controls;
    public Controls Controls
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
      Movement = new Movement(new Movement.Params
      {
        moveSpeed = this.moveSpeed,
      });

      UnityService = new UnityService();

      Controls.Player.PlayerHorizontalMovement.performed += (ctx) => SetMovement(ctx.ReadValue<Vector2>());
      Controls.Player.PlayerHorizontalMovement.canceled += (ctx) => ResetMovement();

      Controls.Player.PlayerJump.performed += (ctx) => SetJumping(true);
      Controls.Player.PlayerJump.canceled += (ctx) => ResetJumping();
    }

    public void OnEnable()
    {
      Controls.Enable();
    }

    public void OnDisable()
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

      Vector3 horizontalMovement = Movement.CalculateHorizontal(
        transform.forward,
        transform.right,
        currentHorizontalInput,
        UnityService.GetDeltaTime()
      );

      characterController.Move(horizontalMovement);
      characterController.Move(verticalVelocity);
    }

    void UpdateGrounded()
    {
      // Чекаем троганье земли
      isGrounded = Physics.CheckSphere(playerGroundPoint.position, 0.1f, playerGroundMask);
    }

    void UpdateGravity()
    {
      verticalVelocity.y += Gravity;

      if (isGrounded && verticalVelocity.y <= 0)
      {
        // Оставляем немного скорости, чтобы убедиться в том что игрок трогает землю
        verticalVelocity.y = -0.1f;
      }

    }

    void UpdateJump()
    {
      if (!currentJumpInput) return;
      if (!isGrounded) return;

      verticalVelocity.y = Mathf.Sqrt(-2f * jumpHeight * Gravity);
    }

    void Update()
    {
      UpdateGrounded();
      UpdateJump();
      UpdateGravity();

      UpdateMovement();
    }
  }
}