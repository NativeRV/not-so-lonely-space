using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.InputSystem;

namespace NSLS.Game.Input
{
  public class PlayerMovementController : NetworkBehaviour
  {
    [SerializeField]
    private float moveSpeed = 5;
    private Vector2 previousInput;

    [SerializeField]
    private CharacterController characterController;

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
      previousInput = inputVector;
    }

    [Client]
    void ResetMovement()
    {
      previousInput = Vector2.zero;
    }

    void Move()
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

      Vector3 movement = sideAxis.normalized * previousInput.x + forwardAxis.normalized * previousInput.y;

      transform.position += (movement * moveSpeed * Time.deltaTime);
    }

    [ClientCallback]
    void Update()
    {
      Move();
    }
  }
}