using UnityEngine;
using MLAPI;

[RequireComponent(typeof(Rigidbody))]
public class GravityBody : NetworkBehaviour
{
  // [SerializeField]
  private GravityAttractor planet;

  new private Rigidbody rigidbody;

  void Awake()
  {
    planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityAttractor>();
    rigidbody = GetComponent<Rigidbody>();

    // Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
    rigidbody.useGravity = false;
    rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
  }

  void FixedUpdate()
  {
    // Allow this body to be influenced by planet's gravity
    planet.Attract(rigidbody);
  }
}