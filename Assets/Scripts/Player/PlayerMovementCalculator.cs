using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
  private float moveSpeed = 0f;
  private float gravity = 0f;

  public Movement(Params parameters)
  {
    moveSpeed = parameters.moveSpeed;
  }

  // Calculate horizontal movement for one frame
  public Vector3 CalculateHorizontal(
    in Vector3 forwardAxis,
    in Vector3 sideAxis,
    in Vector2 horizontalInput,
    in float deltaTime
  )
  {
    // 1. Take vector to forward and right direction, set it to 1
    // 2. Multiply it by input value (-1; 0; 1) 
    var horizontalMovement = sideAxis.normalized * horizontalInput.x +
                      forwardAxis.normalized * horizontalInput.y;

    // 3. Multiply it by moveSpeed and adjust to deltaTime
    horizontalMovement *= moveSpeed * deltaTime;

    return horizontalMovement;
  }

  public class Params
  {
    public float moveSpeed = 0f;
  }
}
