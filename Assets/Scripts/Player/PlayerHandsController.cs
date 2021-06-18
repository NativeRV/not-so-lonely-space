using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NSLS.Game.Input;
using NSLS.Service.UnityService;
using System;
using MLAPI;
using MLAPI.Messaging;

public class PlayerHandsController : NetworkBehaviour
{
  private bool isCurrentlyUsingLeftHand = false;
  private bool isCurrentlyUsingRightHand = false;
  private bool isWantsToShoot = false;

  public GameObject projectile;
  public GameObject cameraMountPoint;
  public GameObject rightHandPoint;
  public GameObject leftHandPoint;
  
  public Animator handsAnimator;

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
    UnityService = new UnityService();

    Controls.Player.PlayerLeftHandUse.performed += (ctx) => SetUsingLeftHand();
    Controls.Player.PlayerLeftHandUse.canceled += (ctx) => UnsetUsingLeftHand();

    Controls.Player.PlayerRightHandUse.performed += (ctx) => SetUsingRightHand();
    Controls.Player.PlayerRightHandUse.canceled += (ctx) => UnsetUsingRightHand();
  }

  public void OnEnable()
  {
    Controls.Enable();
  }

  public void OnDisable()
  {
    Controls.Disable();
  }

  private void SetUsingLeftHand()
  {
    isCurrentlyUsingLeftHand = true;
  }

  private void UnsetUsingLeftHand()
  {
    isCurrentlyUsingLeftHand = false;
  }

  private void SetUsingRightHand()
  {
    isCurrentlyUsingRightHand = true;
    isWantsToShoot = true;
    GameObject.Find("Hands").GetComponent<Animator>().SetTrigger("Attack");
  }

  private void UnsetUsingRightHand()
  {
    isCurrentlyUsingRightHand = false;
  }

  // Update is called once per frame
  void Update()
  {
    if (!IsLocalPlayer) return;

    FireProjectileRequest();
  }

  void FireProjectileRequest()
  {
    if (!isCurrentlyUsingRightHand) return;
    if (!isWantsToShoot) return;

    FireProjectileServerRpc();

    isWantsToShoot = false;
  }

  [ServerRpc]
  void FireProjectileServerRpc()
  {
    var projectileObject = Instantiate(
      projectile,
      rightHandPoint.transform.position,
      Quaternion.identity
    );
    projectileObject.GetComponent<NetworkObject>().Spawn();

    var projectileBody = projectileObject.GetComponent<Rigidbody>();
    // projectileBody.position += new Vector3(0, 3, 0);

    projectileBody.velocity = (cameraMountPoint.transform.forward) * 50;
  }
}
