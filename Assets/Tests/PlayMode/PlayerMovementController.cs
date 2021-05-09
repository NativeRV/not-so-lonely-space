using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSLS.Game.Input;
using NSLS.Service.UnityService;

public class PlayerMovementControllerTest
{
  // A Test behaves as an ordinary method
  [Test]
  public void PlayerMovementControllerSimplePasses()
  {
    // Use the Assert class to test conditions
  }

  // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
  // `yield return null;` to skip a frame.
  [UnityTest]
  public IEnumerator MoveForward()
  {
    yield return null;
    // Use the Assert class to test conditions.
    // Use yield to skip a frame.

    // PlayerMovementController player = new GameObject().AddComponent<PlayerMovementController>();
    // // var mockUnityService = new UnityService {
    // //   public override float GetDeltaTime() => 1f;

    // // };
    // // mockUnityService.GetDeltaTime().Returns(1);

    // player.UnityService = mockUnityService;
    // player.moveSpeed = 5;
    // player.currentHorizontalInput = new Vector2(0, 1);

    // yield return null;

    // Assert.AreEqual(player.transform.position.x, 5);
  }
}
