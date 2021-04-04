using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{

  [SerializeField]
  private float speed = 0.3f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    HandleMovement();
  }

  void HandleMovement()
  {
    if (isLocalPlayer)
    {
      var moveVertical = Input.GetAxis("Vertical");
      var moveHorizontal = Input.GetAxis("Horizontal");
      var mouseX = Input.GetAxis("Mouse X");
      var mouseY = Input.GetAxis("Mouse Y");

      var movement = new Vector3(moveHorizontal, 0, moveVertical);

      transform.position += movement * speed;
      transform.Rotate(mouseX, mouseY, 0);
    }
  }
}
