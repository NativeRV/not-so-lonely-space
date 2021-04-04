using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Cinemachine;
using NSLS.Game.Input;

namespace NSLS.Game.Player
{

  /// <summary>
  /// Этот скрипт навешан на префаб игрока 
  /// Он контроллит его камеру: 
  /// - использование только камеры терущего игрока;
  /// - обзор мышью;
  /// - ротация модельки игрока влево и вправо (но не вверх/вниз);
  /// @Credit: https://www.youtube.com/watch?v=B4vNWUTQues
  /// </summary>
  public class PlayerCameraController : NetworkBehaviour
  {
    [Header("Camera")]
    [SerializeField]
    private Vector2 maxFollowOffset = new Vector2(-1f, 6f);

    [SerializeField]
    private Vector2 cameraVelocity = new Vector2(4f, 0.25f);

    [SerializeField]
    private Transform playerTransform = null;

    [SerializeField]
    private CinemachineVirtualCamera virtualCamera = null;

    private CinemachineTransposer transposer;
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
      transposer = virtualCamera.GetCinemachineComponent<CinemachineTransposer>();

      virtualCamera.gameObject.SetActive(true);

      // Enable updates for PlayerCameraController
      enabled = true;

      // Вешаем коллбэк на PlayerCameraLook экшон (смотри Assets/Inputs/Controls)
      Controls.Player.PlayerCameraLook.performed += (ctx) => Look(ctx.ReadValue<Vector2>());
    }

    // Включаем/выелючаем инпут в зависимости от включённости/выключённости
    // камера контроллера
    [ClientCallback]
    private void OnEnable()
    {
      Controls.Enable();

      // TODO: сделать менюху на эскейп, в которой курсор будет врубаться
      Cursor.visible = false;
    }

    [ClientCallback]
    private void OnDisable()
    {
      Controls.Disable();
      // TODO: сделать менюху на эскейп, в которой курсор будет врубаться
      Cursor.visible = true;
    }

    // Метод рассчитывающий новую позицию и ротэйтящий камеру в зависимости
    // от нипута 
    void Look(Vector2 input)
    {
      // Коэффициент погрешности относительно FPS
      // Для высокого FPS - меньше, для низкого - больше
      // чтобы для любого FPS игра работала одинаково
      float deltaTime = Time.deltaTime;

      // Куча математики, которую я скопипастил
      float followOffsetY = Mathf.Clamp(
        transposer.m_FollowOffset.y - (input.y * cameraVelocity.y * deltaTime),
        maxFollowOffset.x, maxFollowOffset.y
      );

      // Крутим камеру вниз/вверх
      transposer.m_FollowOffset.y = followOffsetY;

      // Крутим игрока влево/вправо
      playerTransform.Rotate(0f, input.x * cameraVelocity.x * deltaTime, 0f);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
  }
}
