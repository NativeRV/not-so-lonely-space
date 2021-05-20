using UnityEngine;
using MLAPI;

public class GravityAttractor : NetworkBehaviour
{

  [SerializeField]
  public float gravityValue = 9.8f;
  public float gravityMultiplier = 1; //0.01f;
  // FIXME: not used
  public float GravityValue { get => -gravityValue * gravityMultiplier; }

  public void Attract(Rigidbody body)
  {
    Vector3 gravityDown = (body.position - transform.position).normalized;
    Vector3 localUp = body.transform.up;

    // Apply downwards gravity to body
    body.AddForce(gravityDown * GravityValue, ForceMode.Acceleration);
    // Allign bodies up axis with the centre of planet
    body.rotation = Quaternion.FromToRotation(localUp, gravityDown) * body.rotation;
  }
}