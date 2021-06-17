using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

  }

  private int stubValue = 0;

  private void OnTriggerEnter(Collider other)
  {
    var othersHealth = other.gameObject.GetComponent<Health>();
    if (!(othersHealth == null))
    {
      othersHealth.TakeDamage(stubValue++ % 10);
    }
    else
    {
      Debug.Log($"Can't find health! Collided with: {other.gameObject.name}");
    }
  }
}
