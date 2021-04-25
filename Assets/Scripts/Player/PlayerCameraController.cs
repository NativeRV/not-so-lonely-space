// using UnityEngine;
// using MLAPI;
// using NSLS.Game.Input;

// namespace NSLS.Game.Player
// {

//   /// <summary>
//   /// Этот скрипт навешан на префаб игрока 
//   /// Он контроллит его камеру: 
//   /// - использование только камеры терущего игрока;
//   /// - обзор мышью;
//   /// - ротация модельки игрока влево и вправо (но не вверх/вниз);
//   /// @Credit: https://www.youtube.com/watch?v=B4vNWUTQues
//   /// </summary>
//   // [RequireComponent(typeof(GameObject))]
//   public class PlayerCameraController : NetworkBehaviour
//   {
//     [Header("Camera")]
//     [SerializeField]
//     private Vector2 mouseSensitivity = new Vector2(4f, 4f);

//     [SerializeField]
//     private GameObject cameraMountPoint = null;

//     [Header("Player root GameObject")]
//     [SerializeField]
//     private Transform playerTransform = null;

//     [Header("Character Controller")]
//     [SerializeField]
//     private CharacterController characterController = null;

//     private float cameraRotationAroundX = 0f;
//     private float cameraRotationAroundY = 0f;

//     private Transform MainCameraTransform
//     {
//       get => Camera.main.gameObject.transform;
//     }

//     private Controls controls;
//     private Controls Controls
//     {
//       get
//       {
//         // Инициализируем систему инпута или реюзаем имеющуюся
//         if (controls != null) return controls;

//         controls = new Controls();
//         return controls;
//       }
//     }

//     public override void OnStartAuthority()
//     {
//       MainCameraTransform.parent = cameraMountPoint.transform;  //Make the camera a child of the mount point
//       MainCameraTransform.position = cameraMountPoint.transform.position;  //Set position/rotation same as the mount point
//       MainCameraTransform.rotation = cameraMountPoint.transform.rotation;

//       // Enable updates for PlayerCameraController
//       enabled = true;

//       // Вешаем коллбэк на PlayerCameraLook экшон (смотри Assets/Inputs/Controls)
//       Controls.Player.PlayerCameraLook.performed += (ctx) => Look(ctx.ReadValue<Vector2>());
//     }

//     // Включаем/выелючаем инпут в зависимости от включённости/выключённости
//     // камера контроллера
//     [ClientCallback]
//     private void OnEnable()
//     {
//       Controls.Enable();

//       // TODO: сделать менюху на эскейп, в которой курсор будет врубаться
//       Cursor.visible = false;
//       Cursor.lockState = CursorLockMode.Locked;
//     }

//     [ClientCallback]
//     private void OnDisable()
//     {
//       Controls.Disable();
//       // TODO: сделать менюху на эскейп, в которой курсор будет врубаться
//       Cursor.visible = true;
//       Cursor.lockState = CursorLockMode.None;
//     }

//     // Метод рассчитывающий новую позицию и ротэйтящий камеру в зависимости
//     // от нипута 
//     void Look(Vector2 input)
//     {
//       // Коэффициент погрешности относительно FPS
//       // Для высокого FPS - меньше, для низкого - больше
//       // чтобы для любого FPS игра работала одинаково
//       float deltaTime = Time.smoothDeltaTime;

//       // Ограничеваем вертикальный поворот ногами и небом и ревёрсим его чтобы было по-человечески
//       var rotationAroundX = -input.y * mouseSensitivity.y * deltaTime;
//       var rotationAroundY = input.x * mouseSensitivity.x * deltaTime;

//       cameraMountPoint.transform.Rotate(rotationAroundX, 0f, 0f);
//       // cameraMountPoint.transform.rotation.x = Mathf.Clamp(cameraMountPoint.transform.rotation.x, -90f, 90f);

//       playerTransform.Rotate(0f, rotationAroundY, 0f);

//       // cameraRotationAroundX += -input.y * mouseSensitivity.y * deltaTime;
//       // cameraRotationAroundY += input.x * mouseSensitivity.x * deltaTime;

//       // cameraRotationAroundX = Mathf.Clamp(cameraRotationAroundX, -90f, 90f);

//       // cameraMountPoint.transform.rotation = Quaternion.Euler(cameraRotationAroundX, 0f, 0f);
//       // playerTransform.rotation = Quaternion.Euler(0f, cameraRotationAroundY, 0f)
//     }

//     // Start is called before the first frame update
//     void Start()
//     {

//     }

//     // Update is called once per frame
//     void Update()
//     {

//     }
//   }
// }
