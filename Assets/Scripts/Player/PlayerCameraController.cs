using UnityEngine;
using MLAPI;
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
  // [RequireComponent(typeof(GameObject))]
  public class PlayerCameraController : NetworkBehaviour
  {
    [Header("Camera")]
    [SerializeField]
    private Vector2 mouseSensitivity = new Vector2(4f, 4f);

    [SerializeField]
    private GameObject cameraMountPoint = null;

    [Header("Player root GameObject")]
    [SerializeField]
    private Transform playerTransform = null;

    [Header("Character Controller")]
    [SerializeField]
    private CharacterController characterController = null;

    private float cameraRotationAroundX = 0f;
    private float cameraRotationAroundY = 0f;

    private Transform MainCameraTransform
    {
      get => Camera.main.gameObject.transform;
    }

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

    public void Start()
    {
      if (!IsLocalPlayer) return;

      MainCameraTransform.parent = cameraMountPoint.transform;  //Make the camera a child of the mount point
      MainCameraTransform.position = cameraMountPoint.transform.position;  //Set position/rotation same as the mount point
      MainCameraTransform.rotation = cameraMountPoint.transform.rotation;

      // Enable updates for PlayerCameraController
      enabled = true;

      // Вешаем коллбэк на PlayerCameraLook экшон (смотри Assets/Inputs/Controls)
      Controls.Player.PlayerCameraLook.performed += (ctx) => Look(ctx.ReadValue<Vector2>());
    }

    // Включаем/выелючаем инпут в зависимости от включённости/выключённости
    // камера контроллера
    private void OnEnable()
    {
      Controls.Enable();

      // TODO: сделать менюху на эскейп, в которой курсор будет врубаться
      // TODO: move this to UnityService
      Cursor.visible = false;
      Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDisable()
    {
      Controls.Disable();

      // TODO: сделать менюху на эскейп, в которой курсор будет врубаться
      Cursor.visible = true;
      Cursor.lockState = CursorLockMode.None;
    }

    // Метод рассчитывающий новую позицию и ротэйтящий камеру в зависимости
    // от нипута 
    void Look(Vector2 input)
    {
      if (!IsLocalPlayer) return;

      // Коэффициент погрешности относительно FPS
      // Для высокого FPS - меньше, для низкого - больше
      // чтобы для любого FPS игра работала одинаково
      float deltaTime = Time.smoothDeltaTime;

      // Ограничеваем вертикальный поворот ногами и небом и инвёртим его чтобы было по-человечески
      var cameraRotationDeltaAroundX = input.y * mouseSensitivity.y * deltaTime;
      var cameraRotationDeltaAroundY = input.x * mouseSensitivity.x * deltaTime;

      cameraRotationAroundX += cameraRotationDeltaAroundX;
      cameraRotationAroundX = Mathf.Clamp(cameraRotationAroundX, -90f, 90f);

      playerTransform.transform.Rotate(Vector3.up * cameraRotationDeltaAroundY);
      cameraMountPoint.transform.localEulerAngles = Vector3.left * cameraRotationAroundX;
    }
  }
}