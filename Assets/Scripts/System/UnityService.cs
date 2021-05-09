using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NSLS.Game.Input;

namespace NSLS.Service.UnityService
{
  public interface IUnityService
  {
    float GetDeltaTime();
  }

  public class UnityService : IUnityService
  {
    public float GetDeltaTime() => Time.deltaTime;
  }
}
